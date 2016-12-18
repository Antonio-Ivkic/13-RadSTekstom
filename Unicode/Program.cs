using System;

namespace Vsite.CSharp
{
    class Unicode
    {
        static void Main(string[] args)
        {
            // latinica
            string varijabla = "đakovački";
            Console.WriteLine(varijabla);

            // ćirilica
            double варијабла = Math.PI;
            Console.WriteLine(варијабла);

            // japanski
            int int変数 = 25;
            Console.WriteLine(int変数);

            string 変数 = "変数の宣言と代入と参照";
            Console.WriteLine(変数);

            Console.ReadKey();
        }
    }
}
