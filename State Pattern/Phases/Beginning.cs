using System;

namespace MagicTheProgramming.State
{
    public class Beginning : Phase
    {
        public Beginning(Game game) : base(game) {}

        public override Phase Advance()
        {
            return new Main();
        }
    }
}
