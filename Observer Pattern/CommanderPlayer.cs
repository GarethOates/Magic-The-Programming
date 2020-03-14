using System;

namespace MagicTheProgramming.ObserverPattern
{
    public class CommanderPlayer : Player
    {
        public CommanderPlayer(string name, int startingLife = 40)
        : base(name, startingLife)
        {

        }
    }
}