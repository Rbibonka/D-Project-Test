using UnityEngine;

[CreateAssetMenu(fileName = "NewJatPackConfig", menuName = "GameData/JatPackConfig")]
public class JatPackConfig : ItemConfig
{
    [field: SerializeField]
    public int Charges { get; private set; }
}