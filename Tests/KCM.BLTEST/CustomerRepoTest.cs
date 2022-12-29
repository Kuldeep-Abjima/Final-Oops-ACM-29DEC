using KCM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KCM.BLTEST
{
    [TestClass]
    public class CustomerRepoTest
    {
        [TestMethod]
        public void RetreieveValid()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                
                EmailAddress = "Hulk@gmail.com",
                FirstName = "Tony",
                LastName = "Stark"
            };
            //--Act
            var actual = customerRepository.Retrieve(1);
            //--Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual (expected.LastName, actual.LastName);
        }
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "Hulk@gmail.com",
                FirstName = "Tony",
                LastName = "Stark",
                AddressesList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "bag End",
                        StreetLine = "Bagshot row",
                        city = "hobbiton",
                        State = "shire",
                        Country = "Middle earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        city = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
                }
            };
            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);


            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressesList[i].AddressType, actual.AddressesList[i].AddressType);
                Assert.AreEqual(expected.AddressesList[i].StreetLine1, actual.AddressesList[i].StreetLine1);
                Assert.AreEqual(expected.AddressesList[i].city, actual.AddressesList[i].city);
                Assert.AreEqual(expected.AddressesList[i].State, actual.AddressesList[i].State);
                Assert.AreEqual(expected.AddressesList[i].Country, actual.AddressesList[i].Country);
                Assert.AreEqual(expected.AddressesList[i].PostalCode, actual.AddressesList[i].PostalCode);

            }
        }
    }
}
