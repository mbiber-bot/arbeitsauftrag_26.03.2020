using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbiber_beispiel2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    Console.Write("Geben Sie eine Zahl ein durch die dividiert werden soll: ");
                    int zahl = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Geben Sie eine zweite Nummer ein: ");
                    int zahl2 = Convert.ToInt32(Console.ReadLine());

                    int erg = zahl / zahl2;
            
                    Console.WriteLine("Ergebnis: {0}", erg);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Eine Rechnung durch 0 ist leider nicht möglich");
            }
            

            
        }

    }
}
