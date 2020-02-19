using System;

namespace MagicTheProgramming.State
{
    public abstract class Phase
    {
        public abstract void Handle(Game context);
    }
}
