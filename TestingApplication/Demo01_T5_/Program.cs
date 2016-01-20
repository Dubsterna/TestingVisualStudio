using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_T5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give seconds ");
            string line = Console.ReadLine();

            int seconds = int.Parse(line);

            int hour = seconds / 3600;
            int min = seconds / 60 - hour * 60;
            int second = seconds % 60;

            Console.WriteLine("Time: {0}h {1}m {2}s", hour, min, second);
        }
    }
}
