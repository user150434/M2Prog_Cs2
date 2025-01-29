using System;

namespace ForHerhaling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        internal static void Run()
        internal static void Run()
        {

            double[] prijzen = { 10.5, 20.3, 30.0 }; // Oude manier
            string[] artikelen = new string[] { "Boek", "Pen", "Schrift" }; // Korte nieuwe manier
            Formulier[] formulieren = new Formulier[3]; // Vaste grootte zonder direct invullen

            formulieren[1] = new Formulier("Formulier 2", "Invullen", DateTime.Now);

            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine($"Prijs {i + 1}: {prijzen[i]}");
            }

            for (int i = 0; i < artikelen.Length; i++)
            {
                Console.WriteLine($"Artikel {i + 1}: {artikelen[i]}");
            }
        }

    }
}
}
