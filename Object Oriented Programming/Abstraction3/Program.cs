using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction3
{
    public abstract class Animal
    {
        public abstract void Name(string name);
    }
    public class Wild : Animal
    {
        public override void Name(string name)
        {
            Console.WriteLine("Name of the animal is : " +name);
        }
         public string Food { get; set; }
        public Wild(string name,string food)
        {
            this.Food = food;
            Console.WriteLine($"{name} eats {food} food");
        }
    }
    public class Domestic : Animal 
    {
        public override void Name(string name)
        {
            Console.WriteLine("Name of the animal is " + name);
        }

        public string Food { get; set; }
        public Domestic(string name,string food)
        {
            this.Food=food;
            Console.WriteLine($"{name} eats {food} food.");
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Wild w = new Wild("Tiger","Nonveg");
            Domestic d = new Domestic("Dog", "Veg and Nonveg");
            Console.ReadLine();
        }
    }
}
