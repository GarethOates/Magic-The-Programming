using System;

namespace MagicTheProgramming.DecoratorPattern
{
    public class Weapon : CreatureDecorator, ICreature
    {
        protected int _powermodifier;
        protected int _toughnessmodifier;

        public Weapon(ICreature creature, int powermod, int toughnessmod)
        : base(creature) {
            this._powermodifier = powermod;
            this._toughnessmodifier = toughnessmod;
        }

        public override int Toughness => base.Toughness + _toughnessmodifier;
        public override int Power => base.Power + _powermodifier;
    }
}
