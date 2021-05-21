using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.BLTest.RepositoryTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {

            //Arrange 
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                FirstName = "Preethi",
                LastName = "Prakash",
                EmailAddress = "preethi93@icloud.com"
            };


            //Act 
            var actual = customerRepository.RetrieveCustomer(1);

            //Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName); 
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            var customerRepo = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Preethi",
                LastName = "Prakash",
                EmailAddress = "preethi93@icloud.com",
                AddressList = new List<Address>()
                { 
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "15 Bickford Rd",
                            City = "Malden",
                        State = "Massachusetts",
                        Country = "USA",
                        PostalCode = 02148

                    },
                     new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "17 Bickford Rd",
                            City = "Malden",
                        State = "Massachusetts",
                        Country = "USA",
                        PostalCode = 02148

                    }
                }
            };

            var actual = customerRepo.RetrieveCustomer(1);

            //assert 
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

            for(int i = 0; i< 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);


            }


        }

    }
}

