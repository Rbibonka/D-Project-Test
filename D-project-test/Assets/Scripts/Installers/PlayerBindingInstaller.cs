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

    private const int startObjectPoolSize = 2;

    public override void InstallBindings()
    {
        Container.Bind<IObjectPool<PoolableObject>>().To<EffectsObjectPool>().AsSingle()
            .WithArguments(effect, startObjectPoolSize);

        Container.Bind<IEffectPlayer>().To<EffectsCreator>().AsSingle();

        Container.Bind<IEquipmentFactory>().To<EquipmentFactory>().AsSingle();

        var playerInstance = Container.InstantiatePrefabForComponent<PlayerController>(playerPrefab);
        playerInstance.Initialize(playerConfig.Health, playerConfig.Nickname, playerConfig.Skills);

        Container.Bind<IPlayer>().FromInstance(playerInstance).AsSingle();
        Container.Bind<IPlayerInfo>().FromInstance(playerInstance).AsSingle();
    }
}