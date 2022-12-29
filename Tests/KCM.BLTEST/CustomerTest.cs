using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KCM.BL;
using System.Security.Cryptography.X509Certificates;
using System.Net.Mail;

namespace KCM.BLTEST
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Kinght",
                LastName = "Dark"
            };
            string expected = "Kinght, Dark";
            //--Act
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameTestValidFirstEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                //FirstName = "Kinght",
                LastName = "Dark"
            };
            string expected = "Dark";
            //--Act
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameTestValidLastEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Kinght",
                //LastName = "Dark"
            };
            string expected = "Kinght";
            //--Act
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            //Arrange--
            var c1 = new Customer();
            c1.FirstName = "Hulk";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "thor";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Tony";
            Customer.InstanceCount += 1;
            //--ACt

            //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "IronMan",
                EmailAddress = "IronMan@Gmail.com"
            };
            var expected = true;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer
            {
                EmailAddress = "IronMan@gmail.com"
            };

            var expected = false;

            //-Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
