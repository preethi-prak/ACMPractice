using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Repository
{
    public class AddressRepository
    {
        public bool SaveAddress()
        {
            return true;
        }

        public Address RetrieveAddress(int addressid)
        {
            Address address = new Address(addressid);

            if (addressid == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "15 Bickford Rd";
                address.City = "Malden";
                address.State = "Massachusetts";
                address.Country = "USA";
                address.PostalCode = 02148;
            }

            return address;
        }

        public IEnumerable<Address> RetrieveAddressByCustID(int customerId)
        {
            var addresslist = new List<Address>();
            Address address = new Address(1)
            {
                StreetLine1 = "15 Bickford Rd",
                City = "Malden",
                State = "Massachusetts",
                Country = "USA",
                PostalCode = 02148,
                AddressType = 1

            };
            addresslist.Add(address);

            Address address1 = new Address(2)
            {
                StreetLine1 = "17 Bickford Rd",
                City = "Malden",
                State = "Massachusetts",
                Country = "USA",
                PostalCode = 02148,
                AddressType = 2

            };
            addresslist.Add(address1);

            return addresslist;

        }
    
        
    }
}
