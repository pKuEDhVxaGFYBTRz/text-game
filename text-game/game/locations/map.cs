using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_game.game.locations
{
    internal class map
    {
        public location[,] grid;

        Random random;

        public map()
        {

            // create new random map
            grid = new location[5,5];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    randomLocation = random.Next(0, (int)locations.size);
                }
            }
        }
    }

    // store data about a location
    struct location
    {
        public int x;
        public int y;

        public location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    // all possible tiles
    enum locations
    {
        village1,
        village2,
        woodsCenter,
        woodsOuter,
        well,
        tavern,
        size = 6, // MUST BE LAST
    }

    //TODO filler location gen
}
