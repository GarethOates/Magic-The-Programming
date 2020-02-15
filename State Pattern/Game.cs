using System;

namespace MagicTheProgramming.State
{
    public class Game
    {
        public Player[] Players {get; set;}
        public Phase CurrentPhase {get; private set;}

        public Game(Player[] players)
        {
            this.Players = players;
            this.CurrentPhase = new Beginning();
        }

        public bool isMainPhase => this.CurrentPhase.GetType() == typeof(Main);

        public void GoToNextPhase(Player player, Phase currentPhase)
        {
            // Check that it's the requesting player's turn.
            // Advance to the next phase.
            CurrentPhase = this.CurrentPhase.Advance();
        }
    }
}
