using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    class PretvorbaStringaUDatum
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Parse("12, 10, 5"));

            string datum = "12:05:2005";
            DateTime dt = DateTime.ParseExact(datum, "dd:MM:yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dt);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
