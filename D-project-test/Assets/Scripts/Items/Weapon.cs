public class Weapon : Item
{
    private int ammo;

    public Weapon(string name, int ammo) : base(name)
    {
        this.ammo = ammo;
    }
}