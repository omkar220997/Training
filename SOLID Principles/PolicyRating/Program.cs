using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyRating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insurance policy rating system is starting....");
            var engine = new RatingEngine();
            engine.Rate();
            if (engine.Rating > 0)
            {
                Console.WriteLine($"Rating: {engine.Rating}");
            }
            else
            {
                Console.WriteLine("No rating Produced");
            }
        }
    }
}
