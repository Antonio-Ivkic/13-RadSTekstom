using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    // primjer base-64 kodiranja
    class Program
    {
        static void Main(string[] args)
        {
            // kodiramo u ASCII; budući da nema naših znakova 
            // sve će biti ispravno
            string tekst = "Dobar dan";
            IspisiKodirajDekodiraj(tekst, Encoding.ASCII);

            // kodiramo u Unicode; svi znakovi zauzimaju 2 bajta
            // pa je kodirani niz dulji
            IspisiKodirajDekodiraj(tekst, Encoding.Unicode);

            // ako imamo naše znakove, ASCII kodiranje će ih "progutati"
            tekst = "ama čovječe";
            IspisiKodirajDekodiraj(tekst, Encoding.ASCII);

            // naše znakove će Unicode i UTF-8 ispravno obraditi
            IspisiKodirajDekodiraj(tekst, Encoding.Unicode);

            IspisiKodirajDekodiraj(tekst, Encoding.UTF8);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        static void IspisiKodirajDekodiraj(string tekst, Encoding kodiranje)
        {
            // ispišimo kodiranje koje će se koristiti
            Console.WriteLine(string.Format("*** Kodiranje: {0} ***", kodiranje.HeaderName));
            Console.WriteLine("Originalni tekst:   {0}", tekst);
            // iz teksta stvaramo niz bajtova
            byte[] bajtovi = kodiranje.GetBytes(tekst);
            // na bajtove primijenimo Base64 kodiranje
            string enkodirano = Convert.ToBase64String(bajtovi);
            Console.WriteLine("Tekst u Base-64:    {0}", enkodirano);

            // dekodiramo bajtove
            bajtovi = Convert.FromBase64String(enkodirano);
            // dekodirane bajtove pretvarmo u string prema zadanom kodiranju
            Console.WriteLine("Dekodirani string:  {0}", kodiranje.GetString(bajtovi));
            // za usporedbu ispisujemo i pojedine bajtove
            Console.Write("Dekodirani bajtovi: ");
            foreach (byte b in bajtovi)
                Console.Write((char)b);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
