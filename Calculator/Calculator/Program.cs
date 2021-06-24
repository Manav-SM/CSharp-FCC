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
            /*
            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 5);
            
            Console.Write("Enter a number1 ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a number2 ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Num1 = " + num1 + " Num2 = " + num2);
            Console.WriteLine(num1 + num2);
            */

            Console.Write("Enter a Number: \n");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: \n");
            string op = Console.ReadLine();

            Console.Write("Enter a Number: \n");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if(op == "+")
            {
                Console.WriteLine(num1 + num2);
            } 
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "%")
            {
                Console.WriteLine(num1 % num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }








            Console.ReadLine();
        }
    }
}
