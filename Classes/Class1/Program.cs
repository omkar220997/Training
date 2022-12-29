using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    public class Agri
    {
        string location;
        int area;
        string crop;

        public Agri(string location, int area, string crop)
        {
            this.location = location;
            this.area = area;
            this.crop = crop;
            
        }
        public string getLocation()
        {
            return location;
        }
        public int getArea()
        {
            return area;
        }
        public string getCrop()
        {
            return crop;
        }

        public void Display()
        {
            Console.WriteLine("The location of the agri is :" + location);
            Console.WriteLine("The area of the agri in acre is :" + area);
            Console.WriteLine("The crop in the agri is :" + crop);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Agri A = new Agri("Satara", 5,"Sugarcane");
            A.Display();
            Console.ReadLine();

        }
    }
}
