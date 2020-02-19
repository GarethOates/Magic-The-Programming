using System;

namespace MagicTheProgramming.State
{
    public class SecondMain : Phase
    {
        public override void Handle(Game context)
        {
            Console.WriteLine("Moving to End Phase");
            context.State = new End();
        }
    }
}
