using System;

namespace MagicTheProgramming.State
{
    public class Main : Phase
    {
        public override void Handle(Game context)
        {
            Console.WriteLine("Moving to Combat Phase");
            context.State = new Combat();
        }
    }
}
