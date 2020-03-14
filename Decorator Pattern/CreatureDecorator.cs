using System;
using MagicTheProgramming.Common;

namespace MagicTheProgramming.DecoratorPattern
{
    public class CreatureDecorator : ICreature
    {
        protected ICreature _creature;

        public CreatureDecorator(ICreature creature)
        {
            this._creature = creature;
        }

        public virtual int Counters {get; set;}

        public virtual string Name => _creature.Name;
        public virtual int Power => _creature.Power;
        public virtual int Toughness => _creature.Toughness;

        public void Update(IPlayer player) {}
    }
}
