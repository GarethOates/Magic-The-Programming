using System;
using System.Linq;
using System.Collections.Generic;

using MagicTheProgramming.Common;

namespace MagicTheProgramming.ObserverPattern
{
    public class Heliod : Creature
    {
        public Heliod(string name, int power, int toughness)
        : base(name, power, toughness)
        {

        }

        public override void Update(IPlayer subject)
        {
            Console.WriteLine($"{this.Name}: {subject.Name} has been updated.");
            Console.WriteLine($"{this.Name}: New Life Total: {subject.LifeTotal}");
            Console.WriteLine($"{this.Name}: Put a +1/+1 counter on target creature or enchantment you control.");
        }
    }
}