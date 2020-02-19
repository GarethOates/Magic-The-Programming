using System;

namespace MagicTheProgramming.State
{
    public class Combat : Phase
    {
        public Combat() { this.CanEquipCreature = false; }

        public override void Handle(Turn turn)
        {
            Console.WriteLine("Moving to 2nd Main Phase");
            turn.Phase = new SecondMain();
        }
    }
}
