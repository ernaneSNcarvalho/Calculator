using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What option of this like: ");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplicate");
            Console.WriteLine("0 - Exit");

            Console.WriteLine("--------------");
            Console.WriteLine("Select one option for excecute: ");

            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Sum(); break;
                case 2: Sub(); break;
                case 3: Div(); break;
                case 4: Mult(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("You enter in function sum!");
            Console.Write("Enter of first value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Enter of second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 + v2;
            Console.WriteLine($"The result of sum of {v1} and {v2} is {result}");
            Console.ReadKey();
            Menu();
        }
        static void Sub()
        {
            Console.Clear();

            Console.WriteLine("You enter in function Subtract!");
            Console.Write("Enter of first value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Enter of second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 - v2;
            Console.WriteLine($"The result of subtract of {v1} and {v2} is {result}");
            Console.ReadKey();
            Menu();
        }

        static void Mult()
        {
            Console.Clear();

            Console.WriteLine("You enter in function of Multiplicate!");
            Console.Write("Enter of first value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Enter of second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 * v2;
            Console.WriteLine($"The result of multiplicate of {v1} and {v2} is {result}");
            Console.ReadKey();
            Menu();
        }
        static void Div()
        {
            Console.Clear();
            Console.WriteLine("You enter in function Division!");
            Console.Write("Enter of first value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Enter of second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 / v2;
            Console.WriteLine($"The result of division of {v1} and {v2} is {result}");
            Console.ReadKey();
            Menu();
        }
    }
}
