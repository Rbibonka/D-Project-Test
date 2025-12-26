using UnityEngine;
using Zenject;

public class ItemBindingInstaller : MonoInstaller
{
    [SerializeField]
    private WeaponConfig weaponConfig;

    [SerializeField]
    private ParachuteConfig parachuteConfig;

    [SerializeField]
    private JatPackConfig jatPackConfig;

    public override void InstallBindings()
    {
        Container.Bind<IItemsCreator>().To<ItemsCreator>().AsSingle()
            .WithArguments(parachuteConfig, weaponConfig, jatPackConfig);
    }
}