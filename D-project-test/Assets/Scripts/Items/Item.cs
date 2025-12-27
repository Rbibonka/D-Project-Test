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

    public void SetToGrabPoint(Transform grabTransform)
    {
        transform.SetParent(grabTransform, true);
        transform.localPosition = Vector3.zero;
    }

    public virtual void Use() { }
}