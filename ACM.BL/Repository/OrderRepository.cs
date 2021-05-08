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
        Order order = new Order();

        if (orderId == 1)
            order.OrderDate = DateTime.Now;

        
        return order; 
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
