using System;

namespace MagicTheProgramming.State
{
    public abstract class Phase
    {
        public bool CanEquipCreature {get; set;}

        public abstract void Handle(Turn turn);
    }
}
