using System;

namespace MagicTheProgramming.State
{
    public class Player
    {
        public string Name {get; set;}
        public int LifeTotal {get; set;}

        public Player(string name, int lifeTotal)
        {
            this.Name = name;
            this.LifeTotal = lifeTotal;
        }
    }
}
