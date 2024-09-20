using Chain_of_Responsibility.Fragen;
using Chain_of_Responsibility.Lehrer;

namespace Chain_of_Responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of Responsibility");

            List<Frage> input = new List<Frage>();
            input.Add(new DeFrage("Is Zeitung das prädikat?"));
            input.Add(new PosFrage("How to center a div?"));
            input.Add(new EngFrage("Was heißt fastidous?"));
            input.Add(new MathFrage("Was is 2+2"));

            Client client = new Client(input);
            PosLehrer posl = new PosLehrer();
            EnglischLehrer engl = new EnglischLehrer();
            DeutschLehrer deutl = new DeutschLehrer();

            posl.SetNext(engl).SetNext(deutl);

            client.Frage(posl);
        }
    }
}
