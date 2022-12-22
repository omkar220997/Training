using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlingelnbergCustomerManagment.BusinessLogic
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerID)
        {
            Customer customer = new Customer();
            if(customerID == 1)
            {
                customer.EmailAdress="omkar.kadam2209@gmial.com";
                customer.FirstName = "Omkar";
                customer.LastName = "Kadam";
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
