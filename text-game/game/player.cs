using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using text_game.game.locations;

namespace text_game.game
{
    public class player
    {
        // public items[] inventory { get; set; }
        public location position { get; set; }

        public bool dead = false;

        public player()
        {
            // create empty inventory
            /*
            inventory = new items[3];
            for (int i = 0; i < inventory.Length; i++) { inventory[i] = items.none; }
            */

            // new position
            position = new location(3,3);
        }
    }
}
