using System;
using System.Diagnostics.CodeAnalysis;

namespace GameConsole
{
    class Program
    {
        static void Main()
        {
            PlayerCharacter p1 = new();
            p1.Name = null;
            //p1.Bio = null;
            Console.WriteLine("Please enter a bio");
            string? bio = Console.ReadLine();
            //Console.WriteLine(p1.Name);
            ExitProgramIfNull(bio, "bio information");
            p1.Bio = bio;
            //Console.WriteLine(p1.Bio);
            Console.ReadLine();
        }
        static void ExitProgramIfNull([NotNull]string? input, string inputDescription)
        {
            if (input is null)
            {
                Console.WriteLine($"{inputDescription} was null, exiting program.");
                Console.ReadLine();
                Environment.Exit(-1);
            }
        }
    }
}
