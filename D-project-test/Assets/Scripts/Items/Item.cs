using UnityEngine;

public abstract class Item : MonoBehaviour, IItem, IViewable
{
    public ItemSocketParts ItemSocketPart { get; private set; }

    protected string Name;

    private IViewable itemView;

    public void InitializeBase(string name, ItemSocketParts itemSocketPart)
    {
        Name = name;
        ItemSocketPart = itemSocketPart;

        itemView = new ItemView(transform);
    }

    public void SetToGrabPoint(Transform grabTransform)
    {
        transform.SetParent(grabTransform, true);
        transform.localPosition = Vector3.zero;
    }

    public virtual void Use()
    {
        Debug.Log("Use");
    }

    public virtual void Show()
    {
        itemView.Show();
    }

    public virtual void Hide()
    {
        itemView.Hide();
    }

    public void HideImmediately()
    {
        itemView.HideImmediately();
    }
}