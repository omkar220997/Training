using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace GameConsole
{
    class Program
    {
        static void Main()
        {
            //PlayerCharacter p1 = new();
            //p1.Name = null;
            //p1.Bio = null;
            //Console.WriteLine("Please enter a bio");
            //string? bio = Console.ReadLine();
            //Console.WriteLine(p1.Name);
            //ExitProgramIfNull(bio, "bio information");
            //p1.Bio = bio;
            //Console.WriteLine(p1.Bio);

            var names = new string[]
            {
                "Omkar","Pankaj","Shubham","Sagar"
            };

            string? firstNameWithZIn = FindFirst<string>(names, name => names.Contains("z"));
            Console.WriteLine(firstNameWithZIn?.Length);
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

        //[return : MaybeNull]
        static T? FindFirst<T>(IEnumerable<T> items, Func<T, bool> predicate)
        {
            foreach(T item in items)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default;
        }
    }
}
