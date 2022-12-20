using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ListCollection class
           /* ListCollection listCollection = new ListCollection();
            listCollection.AddStudentInfo();
            listCollection.DisplyStudentInfo();
           */
           // CompareGenerics Class
           /* CompareGenerics compareGenerics = new CompareGenerics();
            bool result = compareGenerics.Compare<string>("Omkar", "Omkar");
            Console.WriteLine(result);
           */
           // ClassGenerics Class

            ClassGenerics<double> classGenerics = new ClassGenerics<double>();
            classGenerics.Add(15, 20);
            classGenerics.Sub(45, 30);
            classGenerics.Mul(15, 10);
            classGenerics.Div(250, 25);
            
            Console.ReadLine();
        }
    }
}
