using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInGenericCollections
{
    internal class Program
    {
        List<Customer> Customers = new List<Customer>();
        
        private void AddList()
        {
            var customer = new Customer();
            customer.AddCustomer();
            Customers.Add(customer);
        }
        private void CustomerDetails()
        {
            foreach (var customer in Customers)
            {
                customer.ShowCustomer();
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            p.AddList();
            p.CustomerDetails();
            Console.ReadLine();
            
            

            
        }
    }
}
