public class EquipmentFactory : IEquipmentFactory
{
    public Equipment Create()
    {
        var equipment = new Equipment();

        return equipment;
    }
}