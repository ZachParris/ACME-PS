using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using System.Collections.Generic;
using ACM.BL;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fBaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer as ILoggable);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden rake with steel head",
                CurrentPrice = 6m
            };
            changedItems.Add(product as ILoggable);

            //Act
            LoggingService.WriteToFile(changedItems);

            //Assert
            //Nothing to Assert

        }
    }
}
