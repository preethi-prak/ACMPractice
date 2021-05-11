using ACM.BL;
using ACM.BL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

public class CustomerRepository
{

    public AddressRepository addressRepository { get; set; }

    public CustomerRepository()
	{
        addressRepository = new AddressRepository(); 
	}

    public Customer RetrieveCustomer(int customerID)
    {
        Customer customer = new Customer(); 
        if(customerID == 1)
        {
            customer.FirstName = "Preethi";
            customer.LastName = "Prakash";
            customer.EmailAddress = "preethi93@icloud.com";
            customer.AddressList = addressRepository.RetrieveAddressByCustID(customerID).ToList();
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
