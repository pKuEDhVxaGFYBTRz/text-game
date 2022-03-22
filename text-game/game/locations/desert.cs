using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_game.game.locations
{
    internal class desert : Tile
    {
        public new string Name { get; set; } = "desert";
        public new string Description { get; } = "a sandy place";
    }
}
