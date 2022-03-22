using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using text_game.game;
using text_game.game.locations;

namespace text_game
{
    public static class commandFunctions
    {
        public static void left(player player, map map)
        {
            player.position = new location(player.position.x - 1, player.position.y);
            if (player.position.x < 0) { Console.WriteLine("you have fallen off the edge of the flat earth."); player.dead = true; }
        }

        public static void right(player player, map map)
        {
            player.position = new location(player.position.x + 1, player.position.y);
            if (player.position.x > 4) { Console.WriteLine("you have fallen off the edge of the flat earth."); player.dead = true; }
        }

        public static void help(player p, map map)
        {
            Console.WriteLine("use exit to quit the program and view the included markdown doc readme.md");
        }

        public static void suicide(player p, map map)
        {
            Console.WriteLine("you committed suicide"); p.dead = true;
        }

        public static void forwards(player player, map map)
        {
            player.position = new location(player.position.x, player.position.y + 1);
            if (player.position.y < 0) { Console.WriteLine("you have fallen off the edge of the flat earth."); player.dead = true; }
        }

        public static void backwards(player player, map map)
        {
            player.position = new location(player.position.x, player.position.y - 1);
            if (player.position.x > 4) { Console.WriteLine("you have fallen off the edge of the flat earth."); player.dead = true; }
        }
    }
}
