using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerConfig", menuName = "GameData/PlayerConfig")]
public class PlayerConfig : ScriptableObject
{
    [field: SerializeField]
    public int Health { get; private set; }

    [field: SerializeField]
    public string Nickname { get; private set; }

    [field: SerializeField]
    public Skills[] Skills { get; private set; }
}