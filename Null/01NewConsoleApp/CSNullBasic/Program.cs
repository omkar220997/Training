namespace CSNullBasic
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //string? message = null;
            //Console.WriteLine(message);
            Message message = new Message()
            {
                From=null,
                Text="Hello Omkar. How are you?"
            };
            MessagePopulator.Populate(message);

            Console.WriteLine(message.From?? "No From");
            Console.WriteLine(message.From!.Length);
            Console.WriteLine(message.Text);
            Console.WriteLine(message.ToUpperFrom());

            Console.WriteLine("Press Enter to end...");
            Console.ReadLine();
        }
    }
}