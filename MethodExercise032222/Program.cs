using System;

namespace MethodExercise032222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            Console.WriteLine("What is the name of your cat?");
            var userPetName = Console.ReadLine();

            Console.WriteLine("What color is your cat?");
            var userPetColor = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}, he was {age} years old.");
            Console.WriteLine($"He had a {userPetColor} cat named {userPetName}.");
            Console.WriteLine($"{userName} loved {userPetName} and the fact that they were both {age} years old");







        }   

    }
}
