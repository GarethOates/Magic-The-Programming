using System;

namespace MagicTheProgramming.State
{
    public class SecondMain : Phase
    {
        public SecondMain() { this.CanEquipCreature = true; }

        public override void Handle(Turn turn)
        {
            Console.WriteLine("Moving to End Phase");
            turn.Phase = new End();
        }
    }
}
