using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_game.game
{
    public enum items
    {
        none,
        test1,
        test2,
        test3,
    }

    struct inventorySlot
    {
        items item;
        int quantity;

        public inventorySlot(items initial = items.none, int initialQuantity = 0)
        {
            item = initial;
            quantity = initialQuantity;
        }
    }
}
