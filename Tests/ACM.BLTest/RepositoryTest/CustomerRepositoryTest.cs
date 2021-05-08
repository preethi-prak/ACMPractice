using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

    }
}

