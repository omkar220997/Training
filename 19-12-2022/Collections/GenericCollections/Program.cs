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
            ListCollection listCollection = new ListCollection();
            listCollection.AddMarks();
            listCollection.DisplyMarks();
            Console.ReadLine();
        }
    }
}
