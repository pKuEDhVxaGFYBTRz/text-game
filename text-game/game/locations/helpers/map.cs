using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_game.game.locations
{
    public class map
    {
        public Tile[,] grid;
        public const int width = 5;
        public location winning;
        
        private Random random;

        public map()
        {
            locationEnums.locations randomLocationEnum;

            // create new random map
            grid = new Tile[width,width];

            winning = new location(random.Next(width), random.Next(width));

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    
                    randomLocationEnum = locationEnums.RandomEnumValue();
                    Tile tile = locationEnums.lookupLocation(randomLocationEnum);

                    tile.Location = new location(i, j);
                    
                    grid[i,j] = tile;
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
}
