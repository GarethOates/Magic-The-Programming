using System;

namespace MagicTheProgramming.State
{
    public class Beginning : Phase
    {
        public Beginning() { this.CanEquipCreature = false; }

        public override void Handle(Turn turn)
        {
            Console.WriteLine("Moving to Main Phase");
            turn.Phase = new Main();
        }
    }
}
