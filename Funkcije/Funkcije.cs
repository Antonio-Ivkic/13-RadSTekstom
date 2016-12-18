using System;

namespace Vsite.CSharp
{
    // primjer kako funkcioniraju metode sa znakovnim nizovima
    class Program
    {
        static void Main(string[] args)
        {
            string oružje = "katapult";
            string pojam = oružje.Remove(1, 4);

            Console.WriteLine(string.Format("oružje = {0}", oružje));
            Console.WriteLine(string.Format("pojam = {0}", pojam));

            Console.WriteLine();

            string sat = pojam.Insert(pojam.Length, "ura");
            Console.WriteLine(string.Format("pojam = {0}", pojam));
            Console.WriteLine(string.Format("sat = {0}", sat));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
