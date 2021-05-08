using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Address

    {
        public Address()
        {

        }

        public Address(int addressID)
        {
            AddressID = addressID; 
        }
        public int AddressID { get; private set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        public string City { get; set; }

        public string State{ get; set; }

        public int? PostalCode { get; set; }

        public string Country { get; set; }

        public int AddressType { get; set; }

        public bool ValidateAddress()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(StreetLine1))
                isValid = false;
            if (string.IsNullOrEmpty(City))
                isValid = false;
            if (string.IsNullOrEmpty(State))
                isValid = false;
            if (string.IsNullOrEmpty(Country))
                isValid = false;
            if (PostalCode == null || PostalCode <= 0 )
                isValid = false;

            return isValid;

        }

    }

}
