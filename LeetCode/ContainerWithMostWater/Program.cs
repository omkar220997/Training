using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerWithMostWater
{
    internal class Program
    {
        public int MostWater(int[] height)
        {
            int Area=0;
            int[] Cordinates1 = new int[2];
            int[] Cordinates2 = new int[2];
            List<int> CordinateOfX=new List<int>();
            for(int i = 0; i < height.Length; i++)
            {
                Cordinates1[0] = i;
                Cordinates1[1] = 0;
                Cordinates2[0] = i;
                Cordinates2[1] = height[i];
                Console.WriteLine($"Cordinates for {i} is {Cordinates1[0]},{Cordinates1[1]} and {Cordinates2[0]},{Cordinates2[1]}");
                double DistanceOfY = Math.Sqrt(Math.Pow(Cordinates2[0] - Cordinates1[0], 2) + Math.Pow(Cordinates2[1] - Cordinates1[1], 2));
                Console.WriteLine("Distance is" + DistanceOfY);
                CordinateOfX.Add(Cordinates1[0]);
                CordinateOfX.Add(Cordinates1[1]);
            }
            foreach(int cordinate1 in CordinateOfX)
            {
                foreach(int cordinates in Cordinates1)
                {
                    Console.WriteLine(Cordinates1[0] + " " + Cordinates1[1]);

                }
            }
            
            
            


            return Area;
        }
        static void Main(string[] args)
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Program p =new Program();
            p.MostWater(height);
            Console.ReadLine();
        }
    }
}
