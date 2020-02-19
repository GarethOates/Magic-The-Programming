using System;

namespace MagicTheProgramming.State
{
    public class Main : Phase
    {
        public Main() { this.CanEquipCreature = true; }

        public override void Handle(Turn turn)
        {
            Console.WriteLine("Moving to Combat Phase");
            turn.Phase = new Combat();
        }
    }
}
