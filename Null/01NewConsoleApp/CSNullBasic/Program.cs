using System;

namespace CSNullBasic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
#nullable enable
            string message= null;
#nullable disable
            Console.WriteLine(message);

            Console.WriteLine("Press Enter to end...");
            Console.ReadLine();
        }
    }

}
