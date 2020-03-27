using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbiber_beispiel3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("Geben Sie eine Zahl ein:");
                int zahl = Convert.ToInt32(Console.ReadLine());

                Console.Write("Geben Sie eine Zahl ein:");
                int summand = Convert.ToInt32(Console.ReadLine());

                if (summand == 10)
                {
                    throw new Exception("Leider ist eine Addition mit 10 nicht möglich.");
                }

                int summe = zahl + summand;

                Console.WriteLine("Ergebnis: {0}", summe);
            }
            catch
            {
                Console.WriteLine("Leider ist eine Addition mit 10 nicht möglich");
            }
            
        }
    }
}
