using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_game.input
{
    internal class input
    {
        const string prompt = "> ";
        public static string inputCommand()
        {
            // get input
            Console.Write("\n" + prompt);
            string input = Console.ReadLine();

            // clear old text
            Console.Clear();
            Console.WriteLine(prompt + input);
            return input;
        }
    }
}
