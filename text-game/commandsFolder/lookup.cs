using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using text_game.game;
using text_game.game.locations;

namespace text_game
{
    class commandLookup
    {
        public delegate void commandDelegate(player p, map m);

        public static IDictionary<commands, commandDelegate> Mapping = new Dictionary<commands, commandDelegate>
        {
            { commands.forwards,    (player p, map m) => commandFunctions.forwards(p, m) },
            { commands.backwards,   (player p, map m) => commandFunctions.backwards(p, m) },
            { commands.left,        (player p, map m) => commandFunctions.left(p, m) },
            { commands.right,       (player p, map m) => commandFunctions.right(p, m) },
            { commands.look,        (player p, map m) => generalCommandFunctions.look(p, m) },

            { commands.suicide,     (player p, map m) => commandFunctions.suicide(p, m) },

            { commands.help,        (player p, map m) => generalCommandFunctions.help(p, m) },
        };

    }
}