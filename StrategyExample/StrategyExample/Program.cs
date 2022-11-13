using StrategyExample.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample;

internal class Program
{
    static void Main(string[] args)

    {
        Hero Myh = new Hero("Vladimir");
        Console.WriteLine("Start game");

        Myh.Setweapon(new Broom());

        Myh.Addweapon(new Broom());
        Myh.Addweapon(new Broom());
        Myh.Addweapon(new Plunger());

        List<Hero> people = new List<Hero>();

        people.Add(Myh);

        people.Add(new Hero("Andrey"));

        people.Add(new Hero("Valera"));

        foreach (Hero hero in people)
        {
            Console.WriteLine(hero.name);
            if (hero.weapons != null)
            {
               foreach (IWeapon hero1 in hero.weapons)
                {
                    hero1.Shoot();
                }
            }
        }
        people.RemoveAt(people.Count - 1);
        foreach (Hero hero in people)
        {
            Console.WriteLine(hero.name);
        }





        //Hero Myh = new Hero("Vladimir");
        //Console.WriteLine("Start game");

        //Myh.Attack(GunType.Broom);

        //List<Hero> people = new List<Hero>();

        //people.Add(Myh);

        //people.Add(new Hero("Andrey"));

        //people.Add(new Hero("Valera"));

        //foreach (Hero hero in people)
        //{
        //    Console.WriteLine(hero.name);
        //}
        //people.RemoveAt(people.Count - 1);  
        //foreach (Hero hero in people)
        //{
        //    Console.WriteLine(hero.name);
        //}
    }
}
