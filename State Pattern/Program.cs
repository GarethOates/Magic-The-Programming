using System;

namespace MagicTheProgramming.State
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new game. Starting with the beginning phase.
            Game game = new Game(new Beginning());

            // Create some players who are playing the current game.
            Player[] players = new Player[4];
            players[0] = new Player(game, "Inge", 40);
            players[1] = new Player(game, "Gareth", 40);
            players[2] = new Player(game, "Issa", 40);
            players[3] = new Player(game, "Nicko", 4);

            // Lets assume the player defined first always goes first.
            Player currentPlayer = players[0];

            // The currentPlayer performs legal actions for the
            // beginning phase and then decides to start their 1st main phase.
            currentPlayer.GoToNextPhase();
            currentPlayer.GoToNextPhase();
            currentPlayer.GoToNextPhase();
            currentPlayer.GoToNextPhase();
        }
    }
}
