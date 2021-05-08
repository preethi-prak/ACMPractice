using ACM.BL;
using System;
using System.Collections.Generic;

public class ProductRepository
{
	public ProductRepository()
	{
       
    }

    public Product RetrieveProduct(int productID)
    {
        Product product = new Product();

        if (productID == 1)
        {
            product.ProductName = "ABC";
            product.ProductDescription = "Shoes";
            product.CurrentPrice = 233.23M;

        }
        return product;
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
