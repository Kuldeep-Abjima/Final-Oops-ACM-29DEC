using K.Common;
using KCM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting;

namespace K.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WrtieToFileTest()
        {
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "Hulk@gmail.com",
                FirstName = "Tony",
                LastName = "Stark",
                AddressesList = null                
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Mjonir",
                ProductDescription = "Hammer of thunder",
                CurrentPrice = 6M

            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);

        }
    }
}
