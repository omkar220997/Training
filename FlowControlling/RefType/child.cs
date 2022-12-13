using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefType
{
    public class child
    {
        private int age;
        private string name;

        public child()
        {
            name = "N/A";
        }

        public child (int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public void ChildInfo()
        {
            Console.WriteLine($"{name} is {age} years old...");
        }

    }
}
