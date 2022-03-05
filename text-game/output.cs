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
            Console.WriteLine(msg.ToString());
        }

        public static void description(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void errorNoCommand()
        {
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("you must include a command");
            //Console.ResetColor();
        }
    }
}