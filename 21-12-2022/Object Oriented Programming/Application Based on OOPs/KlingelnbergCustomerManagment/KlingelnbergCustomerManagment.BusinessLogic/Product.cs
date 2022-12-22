﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlingelnbergCustomerManagment.BusinessLogic
{
    public class Product: EntityBase
    {
        public Product()
        {

        }
        public Product(int productID)
        {
            ProductID = productID;
        }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        public int ProductID { get; private set; }

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice==null) isValid = false;
            return isValid;
        }
    }
}
