using System;
using System.ComponentModel;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me the value of number a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Now Tell me the value of number b");
            int b = int.Parse(Console.ReadLine());
            int  quotient = a / b;
            var remainder = a % b;

            


            Add(a, b);
            Sub(a, b);
            Mul(a, b);
            Div(a, b);
            Remainder(a, b, quotient, remainder);


            Console.WriteLine("Now lets do the  radius, so type a value ");

            double radius = double.Parse(Console.ReadLine());
            double area = (radius * radius) * Math.PI;

            
            AreaOfCircle(radius, area);

            Console.WriteLine("Now lest do some trivia");
            Console.WriteLine("Choose a value for x");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose a value for y");
            int y = int.Parse(Console.ReadLine());

            //a = x;
            //b = y;

            Console.WriteLine("What is the result of adding x an y  ");
            int z = int.Parse(Console.ReadLine());

            Add(x, y);

           

            int rightAnswer = 0;
            int wrongAnswer = 0;


            CheckAnswer(x, y, z, rightAnswer);






        }

        public static void Add(int a, int b)
        {
            Console.WriteLine($"the result of the adittion is {a + b }");

        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine($"the result of the subtraction is {a - b }");

        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine($"the result of the multiplication is {a * b }");

        }

        public static void Div(int a, int b)
        {
            Console.WriteLine($"the result of the divition is {a / b }");

        }

        public static void Remainder(int a, int b, int quotient, int remainder)
        {
            Console.WriteLine($"{a}/{b} is {quotient} and the remainder is {remainder}");

        }

        public static void AreaOfCircle(double radius, double area)
        {
            Console.WriteLine($"The radius of your circle is {radius} ");
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");

        }

        public static void CheckAnswer(int x, int y, int z, int rightAnswer)
        {
            if( z == x + y)
            {
                Console.WriteLine(" You are right!");
               // return ++rightAnswer

            }

            else
            {
                Console.WriteLine(" You are wrong!");

            }

        }


    }
}
