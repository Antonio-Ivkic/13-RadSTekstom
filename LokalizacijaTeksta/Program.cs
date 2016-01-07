using System;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Upišite kraticu jezika:");
                string oznakaJezika = Console.ReadLine();
                System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo(oznakaJezika);

                System.Resources.ResourceManager tekstovi = new System.Resources.ResourceManager("Vsite.CSharp.Poruke", System.Reflection.Assembly.GetExecutingAssembly());

                string poruka = tekstovi.GetString("Pozdrav", ci);
                Console.WriteLine(poruka);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
