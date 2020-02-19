using System;

namespace MagicTheProgramming.State
{
    public class Combat : Phase
    {
        public override void Handle(Game context)
        {
            Console.WriteLine("Moving to 2nd Main Phase");
            context.State = new SecondMain();
        }
    }
}
