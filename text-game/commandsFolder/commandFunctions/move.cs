using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using text_game.game;

namespace text_game
{
    internal static class commandFunctions
    {
        public static void left(player player)
        {
            player.position.x--;
            if (player.position.x < 0) { Console.WriteLine("you have fallen off the edge of the flat earth."); player.dead = true; }
        }

        public static void right(player player)
        {
            player.position.x++;
            if (player.position.x > 4) { Console.WriteLine("you have fallen off the edge of the flat earth."); player.dead = true; }
        }

        public static void forwards(player player)
        {
            player.position.y++;
            if (player.position.y < 0) { Console.WriteLine("you have fallen off the edge of the flat earth."); player.dead = true; }
        }

        public static void backwards(player player)
        {
            player.position.x--;
            if (player.position.x > 4) { Console.WriteLine("you have fallen off the edge of the flat earth."); player.dead = true; }
        }
    }
}
