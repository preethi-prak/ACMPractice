using ACM.BL;
using System;
using System.Collections.Generic;

public class CustomerRepository
{
	public CustomerRepository()
	{
	}

    public Customer RetrieveCustomer(int customerID)
    {
        Customer customer = new Customer(); 
        if(customerID == 1)
        {
            customer.FirstName = "Preethi";
            customer.LastName = "Prakash";
            customer.EmailAddress = "preethi93@icloud.com";
        }
        return customer;
    }

    public List<Customer> Retrieve()
    {
        return new List<Customer>();
    }

    public bool Save()
    {
        return true;
    }
}
