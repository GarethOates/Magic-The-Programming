using System;

namespace MagicTheProgramming.DecoratorPattern
{
    public class Sword : CreatureDecorator, ICreature
    {
        public Sword(ICreature creature) : base(creature) {}

        public override int Toughness => base.Toughness + 1;
        public override int Power => base.Power + 1;
    }
}
