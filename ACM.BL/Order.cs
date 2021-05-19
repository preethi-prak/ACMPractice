using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public DateTimeOffset? OrderDate { get; set; }

        public int OrderID { get; private set; }
        public List<OrderItem> orderItems { get; set; }


        public Order() : this(0)
        {

        }
        public Order(int orderID)
        {
            OrderID = orderID;
            orderItems = new List<OrderItem>();
        }

        public bool ValidateOrderDate()
        {
            var isValid = true;
            if (OrderDate == null)
                isValid = false;

            return isValid; 
        }

      

    }
}
