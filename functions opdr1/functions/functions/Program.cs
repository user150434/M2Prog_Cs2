using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Program program = new Program();
        program.Run();
    }

    void Run()
    {

        Console.WriteLine("Dit is nu de start van mijn programma");

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


        for (int i = 0; i < 4; i++)
        {
            AskRandomQuestion(vragenLijst);
        }
    }


    string Vraag7()
    {
        return "Why do round pizzas come in square boxes?";
    }


    string GeefRandomVraag(List<string> vragen)
    {
        Random random = new Random();
        int randomIndex = random.Next(vragen.Count);
        return vragen[randomIndex];
    }


    void AskRandomQuestion(List<string> vragen)
    {

        string randomVraag = GeefRandomVraag(vragen);


        Console.WriteLine($"Vraag: {randomVraag}");


        Console.Write("Antwoord: ");
        string antwoord = Console.ReadLine();


        Console.WriteLine($"Je antwoord was: {antwoord}");
        Console.WriteLine();
    }
}
