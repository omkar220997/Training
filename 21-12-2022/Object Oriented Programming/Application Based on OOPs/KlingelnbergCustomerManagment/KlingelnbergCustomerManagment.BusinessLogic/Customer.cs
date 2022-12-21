using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlingelnbergCustomerManagment.BusinessLogic
{
    public class Customer
    {
        //Adding FirstName property using Auto implementation.
        public string FirstName { get; set; }
        // Adding LastName property using full syntax of nget and set property.
        private string _lastName;
        public string LastName
        {
            get 
            {
                return _lastName; 
            }
            set
            {
                _lastName = value;
            }
        }
        // Adding Email property using the pre-defined snippet
        public string EmailAdress { get; set; }
        public int CustomerID { get; private set; }
        public string FullName
        {
            get
            {
                return FullName + " " + LastName;
            }
        }

    }
}
