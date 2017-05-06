﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "CBing@test.me",
                FirstName = "Chandler",
                LastName = "Bing"
            };

            //--Act
            var actual = customerRepository.Retrieve(1);

            //--Assert
            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "CBing@test.me",
                FirstName = "Chandler",
                LastName = "Bing",
                AddressList = new System.Collections.Generic.List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Main St",
                        StreetLine2 = "Franklin Rd",
                        City = "Nashville",
                        State = "TN",
                        Country = "USA",
                        PostalCode = "77069"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot Row",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "145"
                    }
                }
            };

            //act
            var actual = customerRepository.Retrieve(1);

            //assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }



        }
    }
}
