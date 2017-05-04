using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer();
            customer.FirstName = "Chandler";
            customer.LastName = "Bing";

            string expected = "Bing, Chandler";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer();
            customer.FirstName = "Chandler";

            string expected = "Chandler";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            Customer customer = new Customer();
            customer.LastName = "Bing";

            string expected = "Bing";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Chandler";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Joey";
            Customer.InstanceCount += 1;


            var c3 = new Customer();
            c3.FirstName = "Ross";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);

        }

        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer();
            customer.LastName = "Bing";
            customer.EmailAddress = "CBing@test.me";

            var expected = true;
            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer();
            customer.EmailAddress = "CBing@test.me";

            var expected = false;
            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingEmail()
        {
            var customer = new Customer();
            customer.LastName = "Bing";

            var expected = false;
            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateBothEmpty()
        {
            var customer = new Customer();

            var expected = false;
            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
