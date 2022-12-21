using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlingelnbergCustomerManagment.BusinessLogic
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerID)
        {
            CustomerID = customerID;

        }


        //Adding FirstName property using Auto implementation.
        public string FirstName { get; set; }
        // Adding LastName property using full syntax of nget and set property.
       
        public string LastName { get; set; }
        
        // Adding Email property using the pre-defined snippet
        public string EmailAdress { get; set; }
        public int CustomerID { get; private set; }
        public string FullName
        {
            get
            {
                string fullName=FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += " ";
                    }
                    fullName+= LastName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            return isValid;
        }
        
        public Customer Retrieve(int customerID)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }


    }
}
