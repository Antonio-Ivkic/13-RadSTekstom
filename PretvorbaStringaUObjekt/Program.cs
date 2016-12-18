using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    class PretvorbaStringaUObjekt
    {
        static void Main(string[] args)
        {
            try
            {
                double broj = double.Parse("1.234");
                Console.WriteLine(broj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                double broj = double.Parse("1,234");
                Console.WriteLine(broj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                CultureInfo ci = CultureInfo.InvariantCulture;
                double broj = double.Parse("1.234", ci);
                Console.WriteLine(broj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            double broj2;
            if (double.TryParse("1.234A", out broj2))
                Console.WriteLine(broj2);
            else
                Console.WriteLine("Nije uspio!!!");


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
