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
