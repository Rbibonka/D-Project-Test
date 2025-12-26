using System.Collections.Generic;

public class Equipment : IEquipment
{
    private LinkedList<Item> items;

    private LinkedListNode<Item> currentItem;

    public Item CurrentItem => currentItem.Value;

    public Equipment()
    {
        items = new LinkedList<Item>();

        currentItem = items.First;
    }

    public void AddItem(Item item)
    {
        items.AddLast(item);
    }

    public void ChangeItem()
    {
        if (items == null || items.Count < 1)
        {
            return;
        }

        if (currentItem == null || currentItem.Next == null)
        {
            currentItem = items.First;

            return;
        }

        currentItem = currentItem.Next;
    }
}