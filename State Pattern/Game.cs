using System;

namespace MagicTheProgramming.State
{
    public class Game
    {
        private Phase _state;

        public Game(Phase state)
        {
            this.State = state;
        }

        public Phase State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine($"State: {_state.GetType().Name}");
            }
        }

        public void Proceed()
        {
            _state.Handle(this);
        }
    }
}
