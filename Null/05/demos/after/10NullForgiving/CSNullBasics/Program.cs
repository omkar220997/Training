using System;

namespace CSNullBasics
{
    class Program
    {
        static void Main()
        {

            Message message = new() 
            {
                Text = null!,
                From = null
            };

            MessagePopulator.Populate(message);

            Console.WriteLine(message.Text);
            Console.WriteLine(message.From ?? "no from");
            Console.WriteLine(message.From!.Length);
            Console.WriteLine(message.ToUpperFrom());

            Console.WriteLine("Press enter to end.");
            Console.ReadLine();
        }
    }
}
