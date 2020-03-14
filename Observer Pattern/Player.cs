using System;
using System.Linq;
using System.Collections.Generic;

using MagicTheProgramming.Common;

namespace MagicTheProgramming.ObserverPattern
{
    public abstract class Player : IPlayer
    {
        private int _lifeTotal;
        private List<ICreature> _creatures { get; set; }

        public string Name { get; set; }

        public int LifeTotal
        {
            get
            {
                return _lifeTotal;
            }
            set
            {
                if (value > _lifeTotal)
                {
                    Console.WriteLine($"{this.Name} gained life");
                    _lifeTotal = value;

                    Notify();
                }

                _lifeTotal = value;
            }
        }

        public Player(string name, int startingLifeTotal)
        {
            this.Name = name;
            _creatures = new List<ICreature>();

            _lifeTotal = startingLifeTotal;
        }

        public void Attach(ICreature _creature)
        {
            _creatures.Add(_creature);
        }

        public void Detach(ICreature _creature)
        {
            _creatures.Remove(_creature);
        }

        private void Notify()
        {
            foreach (ICreature creature in _creatures)
            {
                creature.Update(this);
            }
        }
    }
}