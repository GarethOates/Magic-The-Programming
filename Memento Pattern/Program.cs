using System;
using System.Text;

namespace MagicTheProgramming.MementoPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameLog log = new GameLog();
            GameLogMemory caretaker = new GameLogMemory();

            log.LogGameAction("1.) Player 1 plays Beetleback Chief");
            caretaker.Memento = log.CreateMemento();

            log.LogGameAction("2.) Player 1 Ends Turn");
            log.LogGameAction("3.) Player 2 plays Barter in Blood");
            log.LogGameAction("4.) Players realise an etb trigger was missed in player 1's turn");
            log.LogGameAction("5.) Players agree to roll back to before player 1's end of turn");

            Console.WriteLine("Current Game Log");
            Console.WriteLine(log.GetGameLog());

            log.RestoreMemento(caretaker.Memento);

            Console.WriteLine("Restored Game Log");
            Console.WriteLine(log.GetGameLog());
        }
    }
}
