using System;
using MagicTheProgramming.Common;

namespace MagicTheProgramming.ObserverPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var player1 = new CommanderPlayer("Gareth");

            Console.WriteLine("Player 1 Casts Ajani's Pridemate");

            ICreature ajani = new Ajani("Ajani's Pridemate", 2, 2);
            player1.Attach(ajani);

            Console.WriteLine($"+1/+1 Counters on Ajani: {ajani.Counters}");

            Console.WriteLine("Player 1 Gains 1 Life");
            player1.LifeTotal += 1;

            Console.WriteLine($"+1/+1 Counters on Ajani: {ajani.Counters}");
        }
    }
}
