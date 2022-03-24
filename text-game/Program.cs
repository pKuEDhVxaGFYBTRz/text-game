using System;
using System.Collections.Generic;
using text_game.game;
using text_game.game.locations;

namespace text_game
{
    internal class Program
    {

        static void Main(string[] args)
        {
            player playerInstance = new player();
            map mapInstance = new map();

            loop(playerInstance, mapInstance);
        }

        public static void loop(player playerInstance, map mapInstance)
        {
            string inputString;
            List<commands> commandList;
            commandLookup.commandDelegate commandToRun;
            bool validCommand;

            while (true)
            {
                // generate the text input string
                inputString = input.input.inputCommand();
                
                // parse it into a list of commands
                commandList = parser.parser.parse(inputString);
                
                // check if there are any commands
                if (commandList.Capacity == 0) { output.errorNoCommand(); }

                // execute commands in order
                foreach (commands command in commandList)
                {
                    validCommand = commandLookup.Mapping.TryGetValue(command, out commandToRun);

                    if (validCommand) { commandToRun(playerInstance, mapInstance); }
                    else { output.errorInvalidCommand(); }
                    Console.WriteLine('\n');

                    if (playerInstance.dead) { output.Death(); return; }
                }
            }
        }
    }
}