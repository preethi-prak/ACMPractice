using ACM.BL;
using System;
using System.Collections.Generic;

public class OrderRepository
{
	public OrderRepository()
	{
	}
    public Order RetrieveOrder(int orderId)
    {
        return new Order();
    }

    public List<Order> RetrieveOrder()
    {
        return new List<Order>();
    }

    public bool SaveOrderInfo()
    {
        return true;
    }
}
