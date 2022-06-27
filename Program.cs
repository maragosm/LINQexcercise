using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var favGames = new List<string>();

            favGames.Add("DeepRock Galactic");
            favGames.Add("Warframe");
            favGames.Add("Minecraft");
            favGames.Add("Terraria");
            favGames.Add("Planetside 2");
            favGames.Add("Valheim");
            favGames.Add("7 Days to Die");
            favGames.Add("Subnautica");

            var gamesListOrdered = favGames.OrderBy(name => name.Length).ToList();

            foreach (var game in gamesListOrdered)
            {
                Console.WriteLine(game);
            }
        }
    }
}
