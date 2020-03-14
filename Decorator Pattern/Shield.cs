using System;
using MagicTheProgramming.Common;

namespace MagicTheProgramming.DecoratorPattern
{
    public class Shield : CreatureDecorator, ICreature
    {
        public Shield(ICreature creature) : base(creature) {}

        public override int Toughness => base.Toughness + 1;
    }
}
