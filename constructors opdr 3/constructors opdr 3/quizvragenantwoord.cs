using constructors_opdr_3;

internal class QuizVraagAntwoord
{
    internal QuizVraag Vraag { get; private set; }
    internal string IngevuldAntwoord { get; set; }  // Verander deze naar 'set;' i.p.v. private set

    internal bool IsCorrect { get; private set; }

    internal QuizVraagAntwoord(QuizVraag vraag, string ingevuldAntwoord)
    {
        Vraag = vraag;
        IngevuldAntwoord = ingevuldAntwoord;
        IsCorrect = vraag.Antwoord.Equals(ingevuldAntwoord, StringComparison.OrdinalIgnoreCase);
    }
}
