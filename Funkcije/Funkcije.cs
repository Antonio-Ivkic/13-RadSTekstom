using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    // primjer kako funkcioniraju metode sa znakovnim nizovima
    class Program
    {
        static void Main(string[] args)
        {
            string oružje = "katapult";
            string pojam = oružje.Remove(1, 4); // "kult"

            Console.WriteLine(string.Format("oružje = {0}", oružje));
            Console.WriteLine(string.Format("pojam = {0}", pojam));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
