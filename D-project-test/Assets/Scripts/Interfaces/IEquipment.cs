public interface IEquipment
{
    void AddItem(Item item);

    void ChangeItem();

    Item CurrentItem { get; }
}