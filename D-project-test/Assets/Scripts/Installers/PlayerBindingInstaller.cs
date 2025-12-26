using Zenject;
using UnityEngine;

public class PlayerBindingInstaller : MonoInstaller
{
    [SerializeField]
    private Player playerPrefab;

    [SerializeField]
    private PlayerConfig playerConfig;

    public override void InstallBindings()
    {
        Container.Bind<IEquipmentFactory>().To<EquipmentFactory>().AsSingle();

        var playerInstance = Container.InstantiatePrefabForComponent<Player>(playerPrefab);
        playerInstance.Initialize(playerConfig.Health, playerConfig.Nickname, playerConfig.Skills);

        Container.Bind<IPlayer>().FromInstance(playerInstance).AsSingle();
    }
}