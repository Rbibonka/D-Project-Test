using UnityEngine;
using Zenject;

public class ItemsCreator : IItemsCreator
{
    private ParachuteConfig parachute;
    private WeaponConfig weapon;
    private JatPackConfig jatPack;

    [Inject]
    public ItemsCreator(ParachuteConfig parachute, WeaponConfig weapon, JatPackConfig jatPack)
    {
        this.parachute = parachute;
        this.weapon = weapon;
        this.jatPack = jatPack;
    }

    public Item CreateWeapon()
    {
        var weapontTemp = (Weapon)GameObject.Instantiate(weapon.ItemPrefab);
        weapontTemp.Initialize(weapon.Damage, weapon.Name, weapon.ItemSocketParts);

        return weapontTemp;
    }

    public Item CreateJatPack()
    {
        var jatPackTemp = (JatPack)GameObject.Instantiate(jatPack.ItemPrefab);
        jatPackTemp.Initialize(jatPack.Charges, jatPack.Name, jatPack.ItemSocketParts);

        return jatPackTemp;
    }

    public Item CreateParachute()
    {
        var parachuteTemp = (Parachute)GameObject.Instantiate(parachute.ItemPrefab);
        parachuteTemp.Initialize(parachute.Name, parachute.ItemSocketParts);

        return parachuteTemp;
    }
}