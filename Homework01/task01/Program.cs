using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int secondNum = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the operation:");
            string operation = Console.ReadLine();

            int result;

            switch (operation)
            {
                case "+":
                result = firstNum + secondNum;
                    Console.WriteLine("The result is:" + result);
                    Console.ReadLine();
                    break;

                case "-":
                result = firstNum - secondNum;
                    Console.WriteLine("The result is:" + result);
                    Console.ReadLine();
                    break;

                case "*":
                    result = firstNum + secondNum;
                    Console.WriteLine("The result is:" + result);
                    Console.ReadLine();
                    break;

                case "/":
                    result = firstNum - secondNum;
                    Console.WriteLine("The result is:" + result);
                    Console.ReadLine();
                    break;
                    
            }           

        }
    }
}
