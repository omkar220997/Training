using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlingelnbergCustomerManagment.BusinessLogic
{
    internal class OrderRepository
    {
        public Order Retrieve(int orderID)
        {
            Order order = new Order();
            if (orderID == 10)
            {
                order.OrderDate= new DateTimeOffset(DateTime.Now.Year,12,22,10,39,00,new TimeSpan(7,0,0));
            }
            return order;
        }
        public bool Save(Order order)
        {
            return true;
        }
    }
}
