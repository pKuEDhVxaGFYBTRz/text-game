using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_game.game.locations
{
    // all locations
    static public class locationEnums
    {
        public enum locations
        {
            dessert,
            woodsCenter,
            woodsOuter,

        }

        public const int LocationLength = 3;

        // https://stackoverflow.com/a/3132139
        // get random value from enum
        static Random _R = new Random ();
        public static locations RandomEnumValue()
        {
            var v = Enum.GetValues (typeof(locations));
            return (locations) v.GetValue (_R.Next(v.Length));
        }

        // convert enum to class instance
        static public Tile lookupLocation(locations locationsParam)
        {
            switch (locationsParam)
            {
                case locations.dessert:         return new desert();
                case locations.woodsCenter:     return new woodsCenter();
                case locations.woodsOuter:      return new woodsOuter();
            }
            return null;
        }
    }
}
