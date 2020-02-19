using System;

namespace MagicTheProgramming.State
{
    public class Turn
    {
        private Phase _phase;

        public Turn()
        {
            this.Phase = new Beginning();
        }

        public Phase Phase
        {
            get { return _phase; }
            set
            {
                _phase = value;
                Console.WriteLine($"State: {_phase.GetType().Name}");
            }
        }

        public void NextPhase()
        {
            _phase.Handle(this);
        }

        public bool CanEquipCreatures()
        {
            return _phase.CanEquipCreature;
        }
    }
}
