using System;

namespace constructors_opdr_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        internal static void Run()
        {

            Quiz quiz = new Quiz(3);

  
            quiz.VoegVraagToeOpIndex(0, "Wat is 2 + 2?", "4");
            quiz.VoegVraagToeOpIndex(1, "Wat is de hoofdstad van Nederland?", "Amsterdam");
            quiz.VoegVraagToeOpIndex(2, "Wat is de grootste planeet?", "Jupiter");

            for (int i = 0; i < quiz.Vragen.Length; i++)
            {
                quiz.StelVraag(i);
            }

            int score = quiz.BerekenScore();

            Console.WriteLine($"Je score is: {score}/{quiz.Vragen.Length}");
        }
    }
}
