namespace functions
{
    internal class Program
    {
        private string? antwoord;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run(); }



        //hier komt mijn code

        internal void vraag1()
        {
            Console.WriteLine("how long do you think you'd survive in a zombie apocalypse");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Run()
        {
            Console.WriteLine("- How long do you think you'd survive in a zombie apocalypse?\r\n- What secret conspiracy would you like to actually start letting other people know?\r\n- If you can still remember, what are your funniest childhood memories?\r\n- What would you do if you won a million dollars?\r\n- What is the worst game you played but that you liked anyway?\r\n- Why do round pizzas come in square boxes?\r\n- Has someone caught you dancing in front of the mirror?\r\n- Have you ever tried talking to a animal?\r\n- What would you call a male ladybug?\r\n- Which species would be the rudest if all animals could talk?");
        }


        internal void vraag7()
        {
            Console.WriteLine("how long do you think you'd survive in a zombie apocalypse");
            string antwoord = Console.ReadLine();

            return antwoord;
        }

        internal class Program
        {
            string[] vraag = new string[] {
                "How long do you think you'd survive in a zombie apocalypse?\r\n" +
                "What secret conspiracy would you like to actually start letting other people know?"
        };

            internal string GetVraag(int vraagindex)
            {
                return vraag[vraagindex];
            }

            string vraag0 = Getvraag(0);


            internal string Getrandomvraag()
            {

                //gebruik random
                int random = ...;
                return ...;

            } } } }
        


