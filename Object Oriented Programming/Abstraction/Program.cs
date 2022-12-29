using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Mobile
    {
        public abstract void Number(long value);
    }

    public class Basic:Mobile
    {
        public override void Number(long value)
        {
            Console.WriteLine("Mobile Number is " +value);
        }
    }
    
    public class Feacture : Basic
    {
        public string music;
        public string call;
        public string game;

        public string Music { get; set; }
        public string Call { get; set; }
        public string Game { get; set; }

        //public override void Number(long value)
        //{
        //    Console.WriteLine("Calling number is " + value);
        //}

        public Feacture(string music, string call, string game)
        {
            this.music = music;
            this.call = call;
            this.game = game;
            Console.WriteLine($"Playe {music} on Music Player");
            Console.WriteLine($"Call to {call} through dail pad");
            Console.WriteLine($"Play {game} in Gaming section");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Feacture f = new Feacture("Hanuman Chalisa" , " Abhi", "BGMI");
            f.Number(8080770371);
            Console.ReadLine(); 
        }
    }
}
