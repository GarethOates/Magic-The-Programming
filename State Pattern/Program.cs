using System;

namespace MagicTheProgramming.State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Start a new turn. Each turn starts with the beginning phase.
            Turn turn = new Turn();

            // A new turn begins. Lets check if we can equip creatures
            // during the beginning phase.
            Console.WriteLine(canEquipCreatures(turn));

            // Nope.  What abobut in the main phase?
            turn.NextPhase();

            // Yup. Creatures can be equipped in the pre-combat main phase.
            Console.WriteLine(canEquipCreatures(turn));

            turn.NextPhase(); // Combat
            turn.NextPhase(); // Second Main
            turn.NextPhase(); // End
        }

        private static string canEquipCreatures(Turn turn)
        {
            return turn.CanEquipCreatures() ?
            "Allowed to Equip Creatures" :
            "Not Allowed to Equip Creatures";
        }
    }
}
