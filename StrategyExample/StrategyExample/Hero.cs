using StrategyExample.Strategies;

class Hero
{
    public string name;
    public IWeapon? heroweapon;
    public List<IWeapon>? weapons;

    public Hero(string name)
    {
    this.name = name;
    this.weapons = new List<IWeapon>();
    }

    public void Addweapon(IWeapon? weapon1)
    {
        this.weapons.Add(weapon1);
    }

    public void Setweapon(IWeapon weapon1)
    {
    this.heroweapon = weapon1;
    }

    public void Attack(GunType weapon)
    {
        switch (weapon)
        { 
            case GunType.Watergun:
                Console.WriteLine($"Нападает водным пистолетом {name}");
                break;

            case GunType.Plunger:
                Console.WriteLine($"Нападает вантузом {name}");
                break;

            case GunType.Broom:
                Console.WriteLine($"Нападает веником {name}");
                break;


        }

       

    }
    

}
enum GunType
{
    Watergun,
    Plunger,
    Broom
}
