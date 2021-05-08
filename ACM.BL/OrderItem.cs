using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public Product product { get; set; }

        public int Quantity { get; set; }

        public double PurchasePrice { get; set; }

        public OrderItem()
        {
                
        }

       public bool ValidateQuantityAndPurchasePrice()
        {
            var isValid = true;
            if (Quantity <= 0)
                isValid = false;
            if (PurchasePrice <= 0)
                isValid = false;

            return isValid;
        }


    }
}
