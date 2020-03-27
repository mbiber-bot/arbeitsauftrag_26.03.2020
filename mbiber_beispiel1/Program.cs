using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbiber_beispiel1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namen = new string[3];

            try
            {
                for (int i = 0; i <= 3 ; i++)
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    namen[i] = name;
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Sie haben leider zu viele Namen eingegeben");
            }
            
        }
    }
}
