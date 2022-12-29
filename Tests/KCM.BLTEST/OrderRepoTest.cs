﻿using KCM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Messaging;

namespace KCM.BLTEST
{
    [TestClass]
    public class OrderRepoTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year,
                4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
            };

            var actual = orderRepository.Retrieve(10);

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}