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
        internal static void look(player p, map m)
        {

            string north, east, south, west;

            try { north = m.grid[p.position.x + 1,  p.position.y + 0].Name; }
            catch { north = "endless void";}
            try { east = m.grid[p.position.x + 0,  p.position.y + 1].Name;  }
            catch { east = "endless void";}
            try { south = m.grid[p.position.x + -1, p.position.y + 0].Name; }
            catch { south = "endless void";}
            try { west = m.grid[p.position.x + 0,  p.position.y + -1].Name; }
            catch { west = "endless void";}


            Console.WriteLine
            (
                "To your north there is a " + north + "\n" +
                "To your east there is a "  + east  + "\n" +
                "To your south there is a " + south + "\n" +
                "To your west there is a "  + west  + "\n"
            );
        }

        internal static void help(player p, map m)
        {
            Console.WriteLine("opening the help file in your default editor");
            System.Diagnostics.Process.Start("help.md");
        }
    }
}
