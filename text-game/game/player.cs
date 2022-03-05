using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_game.game
{
    internal class player
    {
        public items[] inventory;

        public player()
        {
            // create empty inventory
            inventory = new items[3];
            for (int i = 0; i < inventory.Length; i++) { inventory[i] = items.none; }
        }
    }
}
