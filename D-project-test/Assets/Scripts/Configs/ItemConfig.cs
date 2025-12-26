using UnityEngine;

public class ItemConfig : ScriptableObject
{
    [field: SerializeField]
    public string Name { get; private set; }

    [field: SerializeField]
    public ItemSocketParts ItemSocketParts { get; private set; }

    [field: SerializeField]
    public Item ItemPrefab { get; private set; }
}