using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    interface Vehicle
    {
        void ChangeGear(int a);
        void SpeedUp(int a);
        void SpeedDown(int a);
    }

    public class Car : Vehicle
    {
        int gear;
        int speed;
        public void ChangeGear(int newGear)
        {
             gear = newGear;

        }
        public void SpeedUp(int increment)
        {
            speed += increment;
        }
        public void SpeedDown(int decrement)
        {
            speed -= decrement;
        }

        public void Display()
        {
            Console.WriteLine($"speed of car is {speed} on the gear of {gear}");
        }

    } 
    public class Bike : Vehicle
    {
        int gear;
        int speed;
        public void ChangeGear(int newGear)
        {
            gear = newGear;

        }
        public void SpeedUp(int increment)
        {
            speed += increment;
        }
        public void SpeedDown(int decrement)
        {
            speed -= decrement;
        }

        public void Display()
        {
            Console.WriteLine($"speed of bike is {speed} on the gear of {gear}");
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Car c =new Car();
            c.ChangeGear(4);
            c.SpeedUp(100);
            c.SpeedDown(20);
            Console.WriteLine("speed state of car is :");
            c.Display();

            Bike b=new Bike();
            b.ChangeGear(3);
            b.SpeedUp(80);
            b.SpeedDown(10);
            Console.WriteLine("Speed state of bike is :");
            b.Display();
            Console.ReadLine();
        }
    }
}
