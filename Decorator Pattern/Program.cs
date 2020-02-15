using System;
using System.Linq;
using System.Collections.Generic;

namespace MagicTheProgramming.DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a new Creature");
            ICreature creature = new Creature("Nyxborn Courser", 2, 4);

            Console.WriteLine($"Name: {creature.Name}");
            Console.WriteLine($"Base Power: {creature.Power}");
            Console.WriteLine($"Base Toughness: {creature.Toughness}");

            Console.WriteLine("Equipping a Sword to the creature..");

            creature = new Sword(creature);

            getStats(creature);

            Console.WriteLine("Equipping a Shield...");
            Console.WriteLine("Currently Equipped: Sword and Shield");

            creature = new Shield(creature);

            getStats(creature);

            Console.WriteLine("Equipping a Helmet...");
            Console.WriteLine("Currently Equipped: Sword, Shield and Helmet");

            creature = new Helmet(creature);

            getStats(creature);

            Console.WriteLine("Equipping Variable Weapon");

            creature = new Weapon(creature, 5, 10);

            getStats(creature);

            Console.ReadLine();
        }

        private static void getStats(ICreature creature)
        {
            Console.WriteLine($"New Power: {creature.Power}");
            Console.WriteLine($"New Toughness: {creature.Toughness}");
        }
    }
}
