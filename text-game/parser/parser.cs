using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_game.parser
{
    internal class parser
    {
        public static List<commands> parse(string input)
        {
            List<commands> commands = new List<commands>();
            string command;

            foreach (var substring in input.Split(";"))
            {
                // remove whitespace and make lower case
                command = substring.Trim().ToLower();

                // check is not void
                if (string.IsNullOrEmpty(command)) { continue; }

                //Console.WriteLine(mappings.lookup(command));

                // get command
                commands.Add(mappings.lookup(command));
            }

            return commands;
        }
    }
}
