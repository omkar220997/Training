using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterAndSetter2
{
    internal class CustomerProperties
    {
        string _CustomerName;
        string _CustomerStatus;
        string _CustomerEmail;
        double _CustomerMobile;
        double _CustomerAmount;

        internal CustomerProperties()
        {
            Console.WriteLine("Enter Name of Customer");
            _CustomerName = Console.ReadLine();
            Console.WriteLine("Enter the status of Customer");
            _CustomerStatus = Console.ReadLine();
            Console.WriteLine("Enter Email of Customer");
            _CustomerEmail = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number of Customer");
            _CustomerMobile = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Amount of Customer");
            _CustomerAmount = Convert.ToDouble(Console.ReadLine());
        }
        public string CustomerName
        {
            get { return _CustomerName; }
        }
        public string CustomerStatus
        {
            get { return _CustomerStatus; }
        }
        public double CustomerMobile
        {
            get { return _CustomerMobile; }
        }
        public string CustomerEmail
        {
            get { return _CustomerEmail; }
        }
        public double CustomerAmount
        {
            get { return _CustomerAmount; }
        }

        internal void CustomerDisplay()
        {
            Console.WriteLine("Name of the Customer is : " + CustomerName);
            Console.WriteLine("Status of the Customer is : " + CustomerStatus);
            Console.WriteLine("Email of the Customer is : " + CustomerEmail);
            Console.WriteLine("Mobile Number of the Customer is : " + CustomerMobile);
            Console.WriteLine("Amount of the Customer is : " + CustomerAmount);

        }
    }
}
