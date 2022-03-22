using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_game.parser
{
    internal class mappings
    {
        public static commands lookup(string s)
        {
            switch (s)
            {
                // forwards
                case "w": return commands.forwards;
                case "forwards": return commands.forwards;
                case "straight": return commands.forwards;

                // backwards
                case "s": return commands.backwards;
                case "backwards": return commands.backwards;
                case "reverse": return commands.backwards;

                // left
                case "left": return commands.left;
                case "a": return commands.left;

                // right
                case "right": return commands.right;
                case "d": return commands.right;

                // exit
                case "die": return commands.suicide;
                case "suicide": return commands.suicide;
                case "exit": return commands.suicide;

                // case 
                case "help": return commands.help;

                // look around
                case "look" : return commands.look;
                case "inspect" : return commands.look;
                case "l" : return commands.look;

                // default
                default: return commands.invalid;
            }
        }                           
    }
}
