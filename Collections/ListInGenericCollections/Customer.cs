using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInGenericCollections
{
    internal class Customer
    {
        private string CustomerName;
        private double CustomerBill;

        internal void AddCustomer()
        {
            Console.WriteLine("Enter the name of customer");
            CustomerName = Console.ReadLine();
            Console.WriteLine("Enter the bill amount of Customer");
            CustomerBill =Convert.ToDouble( Console.ReadLine());
        }
        internal void ShowCustomer()
        {
            Console.WriteLine("Name of the customer is " + CustomerName);
            Console.WriteLine("Bill of the customer is " + CustomerBill);
        }
    }
}
