using System;

namespace MagicTheProgramming.State
{
    public class Beginning : Phase
    {
        public override void Handle(Game context)
        {
            Console.WriteLine("Moving to Main Phase");
            context.State = new Main();
        }
    }
}
