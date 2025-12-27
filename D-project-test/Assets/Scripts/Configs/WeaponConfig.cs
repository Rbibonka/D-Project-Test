using UnityEngine;

[CreateAssetMenu(fileName = "NewSwordConfig", menuName = "GameData/SwordConfig")]
public sealed class WeaponConfig : ItemConfig
{
    [field: SerializeField]
    public int Damage { get; private set; }
}