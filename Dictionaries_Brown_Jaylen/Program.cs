using System.Collections;
using System.Collections.Generic;
namespace Dictionaries_Brown_Jaylen
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            // Makes a dictionary to store games
            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "Valorent");
            topGames.Add(2, "SF6");
            topGames.Add(3, "GGST");
            topGames.Add(4, "Hollow knight");
            topGames.Add(5, "DMC5");
            topGames.Add(6, "elden ring");
            topGames.Add(7, "GTA");
            topGames.Add(8, "Cyber");
            topGames.Add(9, "fortnite");
            topGames.Add(10, "Cod");

            // Prints all key value pairs in the dictionary
            foreach (KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Checks if key 1 exists and prints the value
            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}");
            }

            // Trys to get a value for a non-existent key using TryGetValue
            string result = "";
            topGames.TryGetValue(11, out result);

            // Checks if result is not empty and prints it
            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("there is no game at 11");
            }

            // Updates the value for key 5
            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Clone drone in the danger zone";
            }

            // Prints updated value for key 5
            Console.WriteLine(topGames[5]);

            // Creates a Hashtable from the Dictionary
            Hashtable hashtable = new Hashtable(topGames);

            // Accesses an item from the Hashtable using a key
            string favGame = (string)hashtable[1];

            // Prints the retrieved value from the Hashtable
            Console.WriteLine($"Favorite game: {favGame}");

            // Creates a hashtable states capitals
            Hashtable capitals = new Hashtable()
        {
            {"Oklahoma","Oklahoma City"},
            {"New York","Albany"},
            {"TeXas","Austin"},
            {"Ohio","Colombus"},
        };

            // Prints all key value pairs in the capitals Hashtable
            foreach (DictionaryEntry kvp in capitals)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Clear all capitals
            capitals.Clear();
        }
    }

}