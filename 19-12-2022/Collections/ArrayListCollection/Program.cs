using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

namespace ArrayListCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList(2);
            arrayList.Add(200);
            Console.WriteLine(arrayList.Capacity);
            arrayList.Add(300);
            arrayList.Add(400);
            arrayList.Add(500);
            arrayList.Add(600);
            arrayList.Reverse();
            arrayList.ToString();

            Console.WriteLine(arrayList.Capacity);
            foreach(Object obj in arrayList)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine(); 
        }
    }
}
