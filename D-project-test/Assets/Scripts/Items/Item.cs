using UnityEngine;

public abstract class Item : MonoBehaviour, IItem
{
    protected string Name;

    public Item(string name)
    {
        Name = name;
    }

    public void Setup(Transform parent) { }

    public virtual void Use() { }
}