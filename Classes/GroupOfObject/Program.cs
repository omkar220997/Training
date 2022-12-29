using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfObject
{
    public class Musician
    {
        public string NameOfMusician { get; set; }
        public string InstrumentPlayedbyMusician { get; set; }
        
        
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Musician[] musician = new Musician[4];
            musician[0] = new Musician {NameOfMusician="Omkar",InstrumentPlayedbyMusician="tabla"};
            musician[1] = new Musician {NameOfMusician="Pranav",InstrumentPlayedbyMusician="Basuri"};
            musician[2] = new Musician {NameOfMusician="Aditya",InstrumentPlayedbyMusician="Harmonium"};
            musician[3] = new Musician {NameOfMusician="Prashil",InstrumentPlayedbyMusician="Guitar"};
            for(int i = 0; i < musician.Length; i++)
            {
                Console.Write($"Name of  the {i + 1} Musician is :");
                Console.WriteLine(musician[i].NameOfMusician);

                Console.Write($"Instrument Played by the {i+1} Musician is :");
                Console.WriteLine(musician[i].InstrumentPlayedbyMusician);

            }

            Console.ReadLine();
                
        }
    }
}
