using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlingelnbergCustomerManagment.BusinessLogic
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderID)
        {
            OrderID = orderID;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; private set; }

        public Order Retrieve(int orderID)
        {
            return new Order();
        }
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;
            if(OrderDate != null) isValid=false;
            return isValid;

        }
    }
}
