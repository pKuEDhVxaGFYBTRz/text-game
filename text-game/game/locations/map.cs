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
            int randomLocation;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    randomLocation = random.Next(0, (int)locations.size);

                    // TODO make location class instance and place on grid
                }
            }
        }
    }

    // store data about a location
    public struct location
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
        size, // MUST BE LAST
    }

    //TODO filler location gen
}
