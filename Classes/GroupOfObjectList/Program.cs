using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfObjectList
{
    public class Musician
    {
        public string NameOfMusician { get; set; }
        public string InstrumentPlayedByMusician { get; set; }

        //public void Display()
        //{
            
        //}
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Musician> Musician=new List<Musician>();
            Musician.Add(new Musician { NameOfMusician = "Omkar", InstrumentPlayedByMusician = "Tabla" });
            Musician.Add(new Musician { NameOfMusician = "Aditya", InstrumentPlayedByMusician = "Basuri" });
            Musician musician = new Musician();
            Console.WriteLine("Name of Musician is :" + musician.NameOfMusician);
            Console.WriteLine("Instrument played by Musician is :" + musician.InstrumentPlayedByMusician);

            Console.ReadLine(); 
        }
    }
}
