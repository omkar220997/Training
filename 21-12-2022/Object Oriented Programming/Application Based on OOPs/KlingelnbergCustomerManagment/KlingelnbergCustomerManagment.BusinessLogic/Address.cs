using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KlingelnbergCustomerManagment.BusinessLogic
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressID)
        {
            AddressID = addressID;
        }

        public int AddressID { get; private set; }
        public int AddressType { get; set; }
        public string City{ get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreerLine2 { get; set; }

        public bool Validate()
        {
            var isVAlid = true;
            if(PostalCode != null) isVAlid = false;
            return isVAlid;
        }
      
    }
}
