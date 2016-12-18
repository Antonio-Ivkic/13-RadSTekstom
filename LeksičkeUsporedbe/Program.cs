using System;
using System.Globalization;

namespace LeksičkeUsporedbe
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ljubav";
            string s2 = "lukav";
            int n = s1.CompareTo(s2);
            Console.WriteLine(string.Format("\"{0}\".CompareTo(\"{1}\") = {2}", s1, s2, n));
            // vraća 1, tj. “ljubav” dolazi poslije “lukav”
            CultureInfo ci = new CultureInfo("de");
            n = string.Compare(s1, s2, true, ci);
            Console.WriteLine(string.Format("string.Compare(\"{0}\", \"{1}\", true, \"de\") = {2}", s1, s2, n));
            // ovo vraća -1, jer njemački jezik ne poznaje slovo
            // ‘lj’ (treći argument je ignoreCase)
            ci = new CultureInfo("hr");
            n = string.Compare(s1, s2, true, ci);
            // ovo sada vraća 1 (kao CompareTo)
            Console.WriteLine(string.Format("string.Compare(\"{0}\", \"{1}\", true, \"hr\") = {2}", s1, s2, n));

            ci = new CultureInfo("de");
            s1 = "strasse";
            s2 = "straße";
            n = string.Compare(s1, s2, true, ci);
            Console.WriteLine(string.Format("string.Compare(\"{0}\", \"{1}\", true, \"de\") = {2}", s1, s2, n));

            n = string.CompareOrdinal(s1, s2);
            Console.WriteLine(string.Format("string.CompareOrdinal(\"{0}\", \"{1}\") = {2}", s1, s2, n));

            Console.ReadKey();
        }
    }
}
