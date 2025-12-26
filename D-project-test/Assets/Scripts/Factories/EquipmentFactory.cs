public class EquipmentFactory : IEquipmentFactory
{
    public IEquipment Create()
    {
        var equipment = new Equipment();

        return equipment;
    }
}