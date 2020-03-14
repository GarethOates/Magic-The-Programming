using System;
using MagicTheProgramming.Common;

namespace MagicTheProgramming.ObserverPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var player1 = new CommanderPlayer("Gareth");

            Console.WriteLine($"{player1.Name} casts Ajani's Pridemate");

            ICreature ajani = new Ajani("Ajani's Pridemate", 2, 2);
            player1.Attach(ajani);

            Console.WriteLine($"{player1.Name} casts Heliod, Sun-Crowned");

            ICreature heliod = new Heliod("Heliod, Sun-Crowned", 5, 5);
            player1.Attach(heliod);

            player1.LifeTotal += 1;
        }
    }
}
