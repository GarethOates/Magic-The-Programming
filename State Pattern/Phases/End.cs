using System;

namespace MagicTheProgramming.State
{
    public class End : Phase
    {
        public override void Handle(Game context)
        {
            Console.WriteLine("Turn over. Starting next player's turn");
            context.State = new Beginning();
        }
    }
}
