using System;

namespace MethodExercise032222
{
    internal class Program
    {

        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            Console.WriteLine("What is the name of your cat?");
            var userCatName = Console.ReadLine();

            Console.WriteLine("What color is your cat?");
            var userCatColor = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}, he was {age} years old.");
            Console.WriteLine($"He had a {userCatColor} cat named {userCatName}.");
            Console.WriteLine($"{userName} loved {userCatName} and the fact that they were both {age} years old");

        }

        static void Main(string[] args)
        {
            MadLib();

            var answer = Sum(8, 5);

            var x = 8;
            var y = 5;

            // var answer = Sum(x, y);

            Console.WriteLine($"{x} + {y} = {Sum(x, y)}");
            Console.WriteLine($"{Sum(5, 4, 8, 2, 9)}");
            Console.WriteLine($"{Sum(15, 74, 38, 92, 9)}");


            // Console.WriteLine($"{x} + {y} = {Subtract(x, y)}");
            // Console.WriteLine($"{x} / {y} = {Division(x, y)}");


        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;

        }

        public static int Sum(params int[] nums)
        {
            var sum = 0;
            foreach(var x in nums)
            {
                sum += x;
            }

            return sum;
        }

        

        




    }
}


