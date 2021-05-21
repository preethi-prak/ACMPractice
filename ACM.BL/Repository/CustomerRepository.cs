using ACM.BL;
using ACM.BL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

public class CustomerRepository
{

    public AddressRepository AddressRepository { get; set; }
    //collaborative relationship between address and customer repository

    public CustomerRepository()
	{
        AddressRepository = new AddressRepository(); 
	}

    public Customer RetrieveCustomer(int customerID)
    {
        Customer customer = new Customer(); 
        if(customerID == 1)
        {
            customer.FirstName = "Preethi";
            customer.LastName = "Prakash";
            customer.EmailAddress = "preethi93@icloud.com";
            customer.AddressList = AddressRepository.RetrieveAddressByCustID(customerID).ToList();
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
