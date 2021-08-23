using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            /* (Using Method Syntax)
                1. DONE---Create a list of video game names..
                2. DONE---Order the list of games by length of the game name.
                3. DONE---Use the lambda expression in this exercise as well.
            */
            var videoGames = new List<string>() { "God of War", "Monster Hunter", "Battlefield", "Ghost of Tsushima", "007" };
            IEnumerable<string> vidGames = videoGames.OrderBy(game => game.Length);
            foreach (string game in vidGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
