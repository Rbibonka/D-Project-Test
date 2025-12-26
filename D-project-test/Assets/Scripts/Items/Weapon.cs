public class Weapon : Item
{
    private int damage;

    public void Initialize(int damage, string name, ItemSocketParts itemSocketPart)
    {
        base.InitializeBase(name, itemSocketPart);

        this.damage = damage;
    }
}