using System;

namespace MagicTheProgramming.State
{
    public class End : Phase
    {
        public End() { this.CanEquipCreature = false; }

        public override void Handle(Turn turn)
        {
            Console.WriteLine("Turn over. Starting next player's turn");
            turn.Phase = new Beginning();
        }
    }
}
