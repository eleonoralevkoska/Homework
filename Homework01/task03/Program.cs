using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int x;
            bool first = int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Enter second number:");
            int y;
            bool second = int.TryParse(Console.ReadLine(), out y);

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine("After swapping:");
            Console.WriteLine("First number:" + x);
            Console.WriteLine("Second number:"+ y);
            Console.ReadLine();


        }
    }
}
