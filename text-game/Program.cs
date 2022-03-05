using System;
using System.Collections.Generic;

namespace text_game
{
    internal class Program
    {

        static void Main(string[] args)
        {
            loop();
        }

        public static void loop()
        {
            string inputString;
            List<commands> commandList;

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
                    
                }

                //Console.WriteLine(commandList.Count);

                Console.WriteLine("test string");

            }
        }
    }
}
