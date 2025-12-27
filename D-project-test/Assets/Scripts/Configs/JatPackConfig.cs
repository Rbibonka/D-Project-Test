using UnityEngine;

[CreateAssetMenu(fileName = "NewJatPackConfig", menuName = "GameData/JatPackConfig")]
public sealed class JatPackConfig : ItemConfig
{
    [field: SerializeField]
    public int Charges { get; private set; }
}