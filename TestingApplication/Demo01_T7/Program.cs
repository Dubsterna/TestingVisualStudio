using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna vuosi ");
            string line = Console.ReadLine();
            int year = int.Parse(line);

            if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("On karkausvuosi.");
            }
            else
            {
                Console.WriteLine("Ei ole karkausvuosi.");
            }
            Console.ReadLine();
        }
    }
}
