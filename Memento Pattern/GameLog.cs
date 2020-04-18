using System;
using System.Text;

namespace MagicTheProgramming.MementoPattern
{
    public class GameLog
    {
        private readonly StringBuilder builder;

        public GameLog()
        {
            builder = new StringBuilder();
            builder.AppendLine("0.) Game Started");
        }

        public void LogGameAction(string action)
        {
            Console.WriteLine(action);
            builder.AppendLine(action);
        }

        public string GetGameLog()
        {
            return builder.ToString();
        }

        public Memento CreateMemento()
        {
            Console.WriteLine("Saving Game State...");
            return (new Memento(builder.ToString()));
        }

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("Restoring Game State...");
            this.builder.Clear();
            this.builder.AppendLine(memento.State);
        }
    }
}