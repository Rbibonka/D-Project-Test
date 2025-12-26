public class RocketPack : Item
{
    private int charges;
    public RocketPack(int charges) : base("RocketPack")
    {
        this.charges = charges;
    }
}