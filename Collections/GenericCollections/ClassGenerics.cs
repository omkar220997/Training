using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class ClassGenerics<T>
    {
      public void Add(T a, T b)
        {
            dynamic Value1=a;
            dynamic Value2=b;
            Console.WriteLine(Value1+Value2);
        }
        public void Sub(T a, T b)
        {
            dynamic Value1 = a;
            dynamic Value2 = b;
            Console.WriteLine(Value1 - Value2);
        }
        public void Mul(T a, T b)
        {
            dynamic Value1 = a;
            dynamic Value2 = b;
            Console.WriteLine(Value1 * Value2);
        }
        public void Div(T a, T b)
        {
            dynamic Value1 = a;
            dynamic Value2 = b;
            Console.WriteLine(Value1 / Value2);
        }
        
    }
}
