using System;

namespace GameConsole
{
    class Program
    {
        static void Main()
        {
            PlayerCharacter p1 = new();
            p1.Name = null;
            p1.Bio = null;
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Bio);
            Console.ReadLine();
        }
    }
}
