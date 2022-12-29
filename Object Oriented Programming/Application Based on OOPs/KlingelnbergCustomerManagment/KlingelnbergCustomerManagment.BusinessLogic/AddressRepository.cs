using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlingelnbergCustomerManagment.BusinessLogic
{
    public class AddressRepository
    {
        Address address = new Address();
        public Address Retrieve(int addressID)
        {
            if (addressID == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Parvati Paytha near Vardhman Medical";
                address.StreerLine2 = "Opposite to Poona Backery";
                address.City = "Pune";
                address.State = "Maharashtra";
                address.Country = "India";
                address.PostalCode = "410009";

            }
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerID)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Parvati Paytha near Vardhman Medical",
                StreerLine2 = "Opposite to Poona Backery",
                City = "Pune",
                State = "Maharashtra",
                Country = "India",
                PostalCode = "410009"
            };
            addressList.Add(address);
            address = new Address(2)
            {
                AddressType = 1,
                StreetLine1 = "At post surli, tel= koregaon, dist= Satara",
                StreerLine2 = "Near Water tank. chorgewadi road",
                City = "Surli",
                State = "Maharashtra",
                Country = "India",
                PostalCode = "415511"

            };
            addressList.Add(address);
            return addressList;

        
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}
