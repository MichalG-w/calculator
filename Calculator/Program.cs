using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("999. Wyjscie");
                Console.WriteLine("0. Nie dziel prze zero");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("4. Mnożenie");

                Console.WriteLine("5. Dzielenie");
                Console.WriteLine("6. Potęgowanie");
                int a = int.Parse(Console.ReadLine());
                if (a == 999)
                {
                    Console.WriteLine("wyjscie");
                    Console.ReadKey();
                    break;
                }

            }
              
            
               
            

        }
    }
}
