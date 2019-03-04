using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number:");
            int fourthNum = int.Parse(Console.ReadLine());

            int result = (firstNum + secondNum + thirdNum + fourthNum) / 4;
            Console.WriteLine("The average of the entered four numbers is:" + result);
            Console.ReadLine();
            
        }
    }
}
