using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }
        public Product()
        {

        }

        public Product(int productID)
        {
            ProductID = productID;
        }

        public override bool Validate()
        {
            var isvalid = true;
            if (String.IsNullOrEmpty(ProductName))
                isvalid = false;
            if (CurrentPrice == null)
                isvalid = false;
            return isvalid; 
        }

   


    }
}
