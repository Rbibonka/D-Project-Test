using Zenject;
using UnityEngine;

public class PlayerBindingInstaller : MonoInstaller
{
    [SerializeField]
    private PlayerController playerPrefab;

    [SerializeField]
    private PlayerConfig playerConfig;

    [SerializeField]
    private Effect effect;

    public override void InstallBindings()
    {
        Container.Bind<IObjectPool<PoolableObject>>().To<EffectsObjectPool>().AsSingle()
            .WithArguments(effect, 2);

        Container.Bind<IEffectPlayer>().To<EffectsCreator>().AsSingle();

        Container.Bind<IEquipmentFactory>().To<EquipmentFactory>().AsSingle();

        var playerInstance = Container.InstantiatePrefabForComponent<PlayerController>(playerPrefab);
        playerInstance.Initialize(playerConfig.Health, playerConfig.Nickname, playerConfig.Skills);

        Container.Bind<IPlayer>().FromInstance(playerInstance).AsSingle();
    }
}