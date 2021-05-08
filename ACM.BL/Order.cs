using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public DateTime OrderDate { get; set; }

        public int OrderID { get; private set; }

        public Order()
        {

        }
        public Order(int orderID)
        {
            OrderID = orderID;
        }

        public bool ValidateOrderDate()
        {
            var isValid = true;
            if (OrderDate.Year < DateTime.Today.Year)
                isValid = false;

            return isValid; 
        }

        public Order RetrieveOrder(int orderId)
        {
            return new Order();
        }

        public List<Order> RetrieveOrder()
        {
            return new List<Order>(); 
        }

        public bool SaveOrderInfo ()
        {
            return true;
        }

    }
}
