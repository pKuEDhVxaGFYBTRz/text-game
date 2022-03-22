using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using text_game.game;
using text_game.game.locations;

namespace text_game
{
    internal static class generalCommandFunctions
    {
        internal static void look(player p)
        {
            throw new NotImplementedException();
        }

        internal static void help(player p)
        {
            Console.WriteLine("opening the help file in your default editor");
            System.Diagnostics.Process.Start("help.md");
        }
    }
}
