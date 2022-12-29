using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlingelnbergCustomerManagment.BusinessLogic
{
    internal class ProductRepository
    {
        public Product Retrieve(int productID)
        {
            Product product = new Product();
            if (productID == 2)
            {
                product.ProductName = "Cylindrical Gear Machine";
                product.ProductDescription = "Machine can have 100 gears per day working capacity";
                product.CurrentPrice = 15000000;
            }
            return product;
        }
        public bool Save(Product product)
        {
            return true;
        }
    }
}
