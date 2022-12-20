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

           /* ClassGenerics<double> classGenerics = new ClassGenerics<double>();
            classGenerics.Add(15, 20);
            classGenerics.Sub(45, 30);
            classGenerics.Mul(15, 10);
            classGenerics.Div(250, 25);
            */

           /* DictionaryCollection dictionaryCollection = new DictionaryCollection();
            dictionaryCollection.AddStudentInfo();
            dictionaryCollection.DisplayStudent();
           */
           //Taking class as a Type in List Collection 
           List<Customer>Customers=new List<Customer>();
            Customer customer1 = new Customer
            {
                CustomerName = "Omkar kadam",
                CustomerEmail = "omkar.kadam@gmail.com",
                CustomerAmount = 2500,
                CustomerMobile = 8080770371
            };
            Customer customer2=new Customer
            {
                CustomerName = "Pankaj Mahale",
                CustomerEmail = "pankaj.mahale@gmail.com",
                CustomerAmount = 3200,
                CustomerMobile = 8888158484
            };
            Customer customer3 = new Customer
            {
                CustomerName = "Shubham Jadhav",
                CustomerEmail = "shubham.jadhav@gmail.com",
                CustomerAmount = 4500,
                CustomerMobile = 7979787979
            };
            Customers.Add(customer1);
            Customers.Add(customer2);
            Customers.Add(customer3);
            foreach(Customer customer in Customers)
            {
                Console.WriteLine(customer.CustomerName+" , "+customer.CustomerEmail+" , "+customer.CustomerMobile+" , "+customer.CustomerAmount);
                
            }
            Console.ReadLine();
        }
    }
}
