using System;

namespace constructors_opdr_3
{
    internal class Quiz
    {
        internal QuizVraag[] Vragen { get; private set; }
        internal string[] IngevuldeAntwoorden { get; private set; }

        internal Quiz(int aantalVragen)
        {
            Vragen = new QuizVraag[aantalVragen];
            IngevuldeAntwoorden = new string[aantalVragen];
        }

        internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            if (index < 0 || index >= Vragen.Length)
            {
                throw new IndexOutOfRangeException("Index ligt buiten de grenzen van de vragenlijst.");
            }
            Vragen[index] = vraag;
        }

        internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            QuizVraag nieuweVraag = new QuizVraag(vraag, antwoord, 1);
            VoegVraagToeOpIndex(index, nieuweVraag);
        }

        internal void StelVraag(int vraagIndex)
        {
            if (vraagIndex < 0 || vraagIndex >= Vragen.Length)
            {
                Console.WriteLine("Ongeldige vraag index.");
                return;
            }

            QuizVraag vraag = Vragen[vraagIndex];

            QuizVraagAntwoord antwoord = new QuizVraagAntwoord(vraag, string.Empty);

            Console.WriteLine(vraag.Vraag);
            string userAntwoord = Console.ReadLine();
            antwoord.IngevuldAntwoord = userAntwoord;

            if (antwoord.IsCorrect)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Onjuist.");
            }

            IngevuldeAntwoorden[vraagIndex] = antwoord.IngevuldAntwoord;
        }

        internal int BerekenScore()
        {
            int score = 0;
            for (int i = 0; i < IngevuldeAntwoorden.Length; i++)
            {
                // Verander IsCorrect() naar IsCorrect zonder haakjes
                if (Vragen[i].Antwoord.Equals(IngevuldeAntwoorden[i], StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
            }
            return score;
        }
    }
}
