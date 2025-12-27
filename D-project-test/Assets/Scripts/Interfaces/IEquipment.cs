public interface IEquipment
{
    IItem CurrentItem { get; }

    IViewable CurrentItemView { get; }

    void AddItem(Item item);

    void ChangeItem();
}