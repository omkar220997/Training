using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlingelnbergCustomerManagment.BusinessLogic
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemID)
        {
            OrderItemId = orderItemID;

        }
        public int OrderItemId { get; private set; }
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem Retrieve(int orderId)
        {
            return new OrderItem();
        }
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if(ProductID<=0) isValid = false;   
            if(PurchasePrice <= 0) isValid = false;
            return isValid;
        }

    }
}
