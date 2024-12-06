using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // We roepen de Run functie aan om de statische Main zo klein mogelijk te houden.
        Program program = new Program();
        program.Run();
    }

    void Run()
    {
        // Dit is nu de start van mijn programma
        Console.WriteLine("Dit is nu de start van mijn programma");

        // Maak een lijst met vragen
        List<string> vragenLijst = new List<string>
        {
            "How long do you think you'd survive in a zombie apocalypse?",
            "What secret conspiracy would you like to actually start letting other people know?",
            "If you can still remember, what are your funniest childhood memories?",
            "What would you do if you won a million dollars?",
            "What is the worst game you played but that you liked anyway?",
            "Why do round pizzas come in square boxes?",
            "Has someone caught you dancing in front of the mirror?",
            "Have you ever tried talking to an animal?",
            "What would you call a male ladybug?",
            "Which species would be the rudest if all animals could talk?"
        };

        // Roep AskRandomQuestion vier keer aan
        for (int i = 0; i < 4; i++)
        {
            AskRandomQuestion(vragenLijst);
        }
    }

    // Functie Vraag7: Geeft een specifieke vraag terug
    string Vraag7()
    {
        return "Why do round pizzas come in square boxes?";
    }

    // Functie GeefRandomVraag: Geeft een willekeurige vraag terug uit de lijst
    string GeefRandomVraag(List<string> vragen)
    {
        Random random = new Random();
        int randomIndex = random.Next(vragen.Count);
        return vragen[randomIndex];
    }

    // Functie AskRandomQuestion: Stelt een willekeurige vraag, vraagt om antwoord, en toont het
    void AskRandomQuestion(List<string> vragen)
    {
        // Haal een random vraag op
        string randomVraag = GeefRandomVraag(vragen);

        // Toon de vraag op het scherm
        Console.WriteLine($"Vraag: {randomVraag}");

        // Vraag om een antwoord van de gebruiker
        Console.Write("Antwoord: ");
        string antwoord = Console.ReadLine();

        // Toon het antwoord op het scherm
        Console.WriteLine($"Je antwoord was: {antwoord}");
        Console.WriteLine(); // Voor een lege regel tussen vragen
    }
}
