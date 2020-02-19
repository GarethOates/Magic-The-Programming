using System;

namespace MagicTheProgramming.State
{
    public class Player
    {
        private string Name;
        private int LifeTotal;

        private Game Game;

        public Player(Game game, string name, int lifeTotal)
        {
            this.Game = game;
            this.Name = name;
            this.LifeTotal = lifeTotal;
        }

        public void GoToNextPhase() => this.Game.Proceed();
    }
}
