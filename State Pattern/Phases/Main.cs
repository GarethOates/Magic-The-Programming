using System;

namespace MagicTheProgramming.State
{
    public class Main : Phase
    {
        public override Phase Advance()
        {
            return new Beginning();
        }
    }
}
