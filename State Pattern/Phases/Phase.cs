using System;

namespace MagicTheProgramming.State
{
    public abstract class Phase
    {
        public Game context;

        public Phase(Game game)
        {
            this.context = game;
        }

        public abstract Phase Advance();
    }
}
