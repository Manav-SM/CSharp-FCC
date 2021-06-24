using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madlib
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color\n");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun\n");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity name\n");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun +" are blue");
            Console.WriteLine("I love " +celebrity);


            Console.ReadLine();
        }
    }
}
