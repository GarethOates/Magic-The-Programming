using System;

namespace MagicTheProgramming.DecoratorPattern
{
    public class Helmet : CreatureDecorator, ICreature
    {
        public Helmet(ICreature creature) : base(creature) {}

        public override int Toughness => base.Toughness + 5;
    }
}
