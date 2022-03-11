using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using text_game.game;

namespace text_game
{
    class commandLookup
    {
        public delegate void commandDelegate(player p);

        public static IDictionary<commands, commandDelegate> Mapping = new Dictionary<commands, commandDelegate>
        {
            { commands.forwards, (player p) => commandFunctions.forwards(p) },
            { commands.backwards, (player p) => commandFunctions.backwards(p) },
            { commands.left, (player p) => commandFunctions.left(p) },
            { commands.right, (player p) => commandFunctions.right(p) },
        };

    }
}