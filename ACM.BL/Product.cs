using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public string Description { get; set; }

        public double CurrentPrice { get; set; }
        public Product()
        {

        }

        public Product(int productID)
        {
            ProductID = productID;
        }

        public bool ValidateProductNameAndPrice()
        {
            var isvalid = true;
            if (String.IsNullOrEmpty(ProductName))
                isvalid = false;
            if (CurrentPrice <= 0)
                isvalid = false;
            return isvalid; 
        }

        public Product RetrieveProduct(int productID)
        {
            return new Product();
        }

        public List<Product> RetrieveProduct()
        {
            return new List<Product>();
        }

        public bool SaveProductInfo()
        {
            return true; 
        }


    }
}
