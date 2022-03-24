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

        public static void destination(string name)
        {
            Console.Write("you have arrived at a ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(name);
            Console.ResetColor();
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

        public static void HasWon()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("you have won! find the next objective.");
            Console.ResetColor();
        }

        public static void errorInvalidCommand()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("can you rephrase that please?");
            Console.ResetColor();
        }

        public static void Death()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("you have died.");
            Console.ResetColor();
        }
    }
}