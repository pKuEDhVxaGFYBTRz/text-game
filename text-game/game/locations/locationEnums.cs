using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_game.game.locations
{
    static public class locationEnums
    {
        public enum locations
        {
            dessert,
            woodsCenter,
            woodsOuter,

        }

        static public Tile lookupLocation(locations locationsParam)
        {
            switch (locationsParam)
            {
                case locations.dessert: return new desert();
                case locations.woodsCenter: return new woodsCenter();
                case locations.woodsOuter: return new woodsOuter();
            }
            return null;
        }
    }
}
