using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerID { get; private set; }

        public static int  InstanceCount { get; set; }

        public string FullName
        {
            get
            {
                string fullname = LastName;
                {
                    if (!string.IsNullOrEmpty(FirstName))
                    {
                        if (!string.IsNullOrEmpty(fullname))
                        {
                            fullname += ",";
                        }
                        fullname += FirstName;
                    }
                    return fullname;
                }
            }
        }

        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerID = customerId; 
        }

        public bool Validate ()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(LastName))
                isValid = false;
            if (string.IsNullOrEmpty(EmailAddress))
                isValid = false;

            return isValid; 
        }

       

    }
}
