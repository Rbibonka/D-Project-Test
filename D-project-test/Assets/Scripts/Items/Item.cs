using UnityEngine;

public abstract class Item : MonoBehaviour, IItem
{
    public ItemSocketParts ItemSocketPart { get; private set; }

    protected string Name;

    public void InitializeBase(string name, ItemSocketParts itemSocketPart)
    {
        Name = name;
        ItemSocketPart = itemSocketPart;
    }

    public void Setup(Transform parent)
    {
        transform.SetParent(parent, true);
        transform.localPosition = Vector3.zero;
    }

    public virtual void Use() { }
}