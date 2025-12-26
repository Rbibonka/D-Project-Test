using System.Collections.Generic;

public class Equipment : IEquipment
{
    private List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);
    }
}