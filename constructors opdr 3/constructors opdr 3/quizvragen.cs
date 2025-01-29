using System;

namespace constructors_opdr_3
{
    internal class QuizVraag
    {
        internal string Vraag { get; private set; }
        internal string Antwoord { get; private set; }
        internal int Moeilijkheidsgraad { get; private set; }

        internal QuizVraag(string vraag, string antwoord, int moeilijkheidsgraad)
        {
            Vraag = vraag;
            Antwoord = antwoord;
            Moeilijkheidsgraad = moeilijkheidsgraad;
        }
    }
}
