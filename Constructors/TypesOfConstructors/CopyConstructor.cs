using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfConstructors
{
    internal class CopyConstructor
    {
        string CompnayName;
        internal CopyConstructor(string compnayName)
        {
            CompnayName = compnayName;
        }   
        internal CopyConstructor(CopyConstructor name)
        {
            CompnayName=name.CompnayName;
        }
        internal void Display()
        {
            Console.WriteLine("Name of the company is " +CompnayName);
        }
    }
}
