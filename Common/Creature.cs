using System;

namespace MagicTheProgramming.Common
{
    public class Creature : ICreature
    {
        public int Counters {get; set;}
        public string Name {get;}
        public int Power {get;}
        public int Toughness {get;}

        public Creature(string name, int power, int toughness)
        {
            this.Name = name;
            this.Power = power;
            this.Toughness = toughness;
        }

        public virtual void Update() {}
    }
}

