using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public decimal? PurchasePrice { get; set; }

        public int OrderItemId { get; private set; }

        public OrderItem()
        {
                
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId; 
        }

       public bool ValidateQuantityPurchasePriceAndProductID()
        {
            var isValid = true;
            if (Quantity <= 0)
                isValid = false;
            if (PurchasePrice == null)
                isValid = false;
            if (ProductID <= 0)
                isValid = false;

            return isValid;
        }

        public OrderItem RetrieveOrderItem(int orderItemId)
        {
            return new OrderItem();
        }

        public List<OrderItem> RetrieveOrderItem ()
        {
            return new List<OrderItem>();
        }

        public bool SaveOrderItem()
        {
            return true;
        }

    }
}
