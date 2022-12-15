using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Band
    {
        public string BandName;
        public List<Musician> Musicians=new List<Musician>();
        public void AddMusician()
        {
            Band band = new Band();
            Musician musician = new Musician();
            Console.WriteLine("Name of the Musician is ");
            musician.NameOfMusician=Console.ReadLine();
            Console.WriteLine("Instrument Played by the musician is ");
            musician.InstrumentOfMusician=Console.ReadLine();
            Musicians.Add(musician);
        }
        public void Announce()
        {

            Console.WriteLine("Welcome " + BandName + " on stage!!!");
            foreach(var musician in Musicians)
            {
                musician.Announce();
            }
        }

       
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Musician musician = new Musician(); 
            Console.WriteLine("What is the name of your band?");
            Band band=new Band();
            band.BandName=Console.ReadLine();

            Console.WriteLine("Type 'Add' to add a musician.");
            Console.WriteLine("Type 'Announce' to announce the band.");
            Console.WriteLine("Type 'Quit' to quit the application.");
            var Repeat = true;
            while (Repeat)
            {
                Console.WriteLine("Add,Announce, or Quit");
                var Action = Console.ReadLine();
                if (Action == "Add")
                {
                    band.AddMusician();

                }
                else if(Action == "Announce")
                {
                    band.Announce();
                    //musician.Announce();
                }
                else if (Action == "Quit")
                {
                    Repeat = false;
                }
                else
                {
                    Console.WriteLine(Action + " is not a valid command");
                }
            }
        }
    }
}
