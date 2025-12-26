public class JatPack : Item
{
    private int charges;

    public void Initialize(int charges, string name, ItemSocketParts itemSocketPart)
    {
        base.InitializeBase(name, itemSocketPart);

        this.charges = charges;
    }
}