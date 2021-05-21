using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //arrange
            Customer customer = new Customer
            {
                FirstName = "Preethi",
                LastName = "Prakash"
            };

            string expectedval = "Prakash,Preethi";

            //act 
            string actualval = customer.FullName;

            //assert 
            Assert.AreEqual(expectedval,actualval);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
           
            Customer customer = new Customer
            {
                LastName = "Prakash"

            };
            string expected = "Prakash";

            //act 
            string actual = customer.FullName;

            //assert

            Assert.AreEqual(expected, actual); 

        }


        [TestMethod]
        public void FullNameLastNameEmpty()
        {

            Customer customer = new Customer
            {
                FirstName = "Preethi"

            };
            string expected = "Preethi";

            //act 
            string actual = customer.FullName;

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StaticTest()
        {

            Customer c1 = new Customer
            {
                FirstName = "Preethi"

            };
            Customer.InstanceCount += 1;

            Customer c2 = new Customer
            {
                FirstName = "Deepthi"

            };
            Customer.InstanceCount += 1;


            Customer c3 = new Customer
            {
                FirstName = "Arya"

            };
            Customer.InstanceCount += 1;

            //act 
        
            //assert

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateTest()
        {
            //arrange
            Customer c = new Customer
            {
                
                LastName = "Prakash",
                EmailAddress = "Preethi93@icloud.com"

            };
            //act
            var Expectedval = true;
            var actualval = c.Validate();
            //assert
            Assert.AreEqual(Expectedval, actualval);
        }

        [TestMethod]
        public void ValidateMissingLastName ()
        {
            //arrange
            Customer c = new Customer
            {

                EmailAddress = "Preethi93@icloud.com"
            };
            //act
            var Expectedval = false;
            //assert
            Assert.AreEqual(Expectedval, c.Validate());
        }

        [TestMethod]
        public void ValidateMissingEmail()
        {
            //arrange
            Customer c = new Customer
            {
                LastName = "Preethi"
            };
            //act
            var Expectedval = false;
            //assert
            Assert.AreEqual(Expectedval, c.Validate());
        }

    }
}
