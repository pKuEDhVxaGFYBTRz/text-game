using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_game
{
    internal class output
    {
        public static void message(string msg)
        {
            Console.Write(msg.ToString());
        }

        public static void description(string msg)
        {
            Console.Write(msg);
        }

        public static void errorNoCommand()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("you must include a command");
            Console.ResetColor();
        }

        internal static void errorInvalidCommand()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("can you rephrase that please?");
            Console.ResetColor();
        }

        internal static void Death()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("you have died.");
            Console.ResetColor();
        }
    }
}