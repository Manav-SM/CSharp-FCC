using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Greetings Earthlings!");
            Console.WriteLine("Middle");
            Console.WriteLine("Goodbye World!");

            //Drawing a shape
            Console.WriteLine("    /|");
            Console.WriteLine("   / |");
            Console.WriteLine("  /  |");
            Console.WriteLine(" /   |");
            Console.WriteLine("/____|");

            //Variable
            string characterName = "George";
            float characterAge = 70;

            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("His name was " + characterName );

            characterName = "Mike";
            characterAge = 30;

            Console.WriteLine("He wished his name was " +characterName);
            Console.WriteLine("He wished he was " + characterAge + " years old forever");

            Console.WriteLine("There was once a man named George");
            Console.WriteLine("He was 70 years old");
            Console.WriteLine("He really liked the name George");
            Console.WriteLine("He didn't like being 70");

            //Strings
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 45;
            double number = 45.5451;
            bool isMale = true;

            Console.WriteLine(phrase);
            Console.WriteLine(grade);
            Console.WriteLine(age);
            Console.WriteLine(number);
            Console.WriteLine(isMale);

            //Working with Strings
            Console.WriteLine("Giraffe\nAcademy");
            string phrase2 = "Giraffe Academy " + "is cool";
            Console.WriteLine(phrase2);
            Console.WriteLine(phrase2.Length);
            Console.WriteLine(phrase2.ToUpper());
            Console.WriteLine(phrase2.Contains("Academy"));
            Console.WriteLine(phrase2.Contains("University"));
            Console.WriteLine(phrase2[3]);
            Console.WriteLine(phrase2[8]);
            Console.WriteLine(phrase2.IndexOf("c"));
            Console.WriteLine(phrase2.IndexOf("cool"));
            Console.WriteLine(phrase2.IndexOf("hot"));
            Console.WriteLine(phrase2.Substring(4,2));

            //Working with Numbers
            Console.WriteLine(-426.24566);
            Console.WriteLine(8245.66);
            Console.WriteLine(894 + 4894 - 4651);
            Console.WriteLine(7 % 5);
            Console.WriteLine(83.9 + 448.97);
            Console.WriteLine(12.6 + 84);
            Console.WriteLine(12 / 2.5);
            int num = 6;
            Console.WriteLine(num);
            num++;
            Console.WriteLine(num);
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(27.5, 2));
            Console.WriteLine(Math.Sqrt(81));
            Console.WriteLine(Math.Max(44,65));
            Console.WriteLine(Math.Round(55.78));
            

            //Getting User Input
            Console.Write("Enter your name: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Hello " + name2);
            Console.Write("Enter your age: ");
            string age2 = Console.ReadLine();
            Console.WriteLine("Hello " + name2 + ", you are " + age2 + " years old");
            
            //Arrays
            int[] luckyNumbers = {2,3,5,7,11,13 };
            string[] friends = new string[5];

            friends[0] = "Amey";
            friends[1] = "Amogh";


            Console.WriteLine(friends[1]);
            Console.WriteLine(luckyNumbers[5]);
            

            //Methods
            SayHi("Manav", 27);
            SayHi("Amey", 27);
            SayHi("Amogh", 30);

            cube(9);
            Console.WriteLine(cube(11));
            

            //Loops

            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } 
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are male and short");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are tall and not a male");
            }
            else
            {
                Console.WriteLine("You are neither a male nor tall");
            }

            Console.WriteLine(GetMax(7, 41));

            int testIndex = 1;
            while(testIndex<= 10)
            {
                Console.WriteLine(testIndex);
                testIndex++;
            }
           

            Console.WriteLine(GetPow(5, 3));
            

            //Array

            int[,] numberGrid =
            {
                {1,2 },
                {3,4 },
                {5,6 }
            };

            Console.WriteLine(numberGrid[1, 1]);
            int rowLength = numberGrid.GetLength(0);
            int colLength = numberGrid.GetLength(1);


            for (int i = 0; i < rowLength; i ++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(numberGrid[i, j]);
                }
                Console.WriteLine();
            }
            */











            Console.ReadLine();
        }
        static int GetPow(int baseNum, int powNum)
        {
            int result3 = 1;

            for(int i=0; i<powNum; i++)
            {
                result3 = result3 * baseNum;
            }

            return result3;
        }
        static int GetMax(int num1, int num2)
        {
            int result;

            if(num1<num2)
            {
                result = num2;
            }else
            {
                result = num1;
            }

            return result;
        }
        static void SayHi (string name, int age)
        {
            Console.WriteLine("Say Hi, "+ name +" you are " + age + " years old.");
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}
