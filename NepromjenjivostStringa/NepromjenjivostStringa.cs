using System;

namespace Vsite.CSharp
{
    class NepromjenjivostStringa
    {
        public static string DolijepiTekst(string original, string zakrpa)
        {
            string temp = original;
            original += zakrpa;
            return original;
        }

        static void Main(string[] args)
        {
            // TODO: Pogledati u MSDN-u kako je definirana klasa String.

            // TODO: Pokrenuti program i provjeriti ispis.
            // TODO: Postaviti točku prekida (breakpoint) u metodu DolijepiTekst. Pokrenuti program i kada se izvođenje zaustavi, dodati prikaz &original i &temp te proširiti prikaz te pogledati što se događa tijekom izvođenja metode. 
            string tekst = "Dobar ";
            string noviTekst = DolijepiTekst(tekst, "dan!");

            Console.WriteLine(tekst);
            Console.WriteLine(noviTekst);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
