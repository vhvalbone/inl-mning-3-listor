using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> landStorlekar = new Dictionary<string, int>()
        {
            {"Sverige", 450},
            {"Norge", 385},
            {"Danmark", 43},
            {"Finland", 338}
        };

        Console.Write("Skriv namnet på ett av följande länder: Sverige, Norge, Danmark, Finland: ");
        string inputLand = Console.ReadLine();

        if (landStorlekar.ContainsKey(inputLand))
        {
            int storlek = landStorlekar[inputLand];
            Console.WriteLine($"Storleken på {inputLand} är {storlek} hundratusentals kvadratkilometer.");
        }
        else
        {
            Console.WriteLine("Landet du angav finns inte i listan.");
        }
    }
}