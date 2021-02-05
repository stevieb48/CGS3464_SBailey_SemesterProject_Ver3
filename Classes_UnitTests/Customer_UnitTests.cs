// @author: Stephen Bailey
// course: CGS3464
// assignment: final project
// date: 10/08/2018
// file name: Customer_UnitTests.cs
// @version: 1.0
//
// Description
// This includes tests for the 'Customer' class.

using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes_UnitTests
{
    [TestClass]

    public class Customer_UnitTests
    {
        [TestMethod]
        public void CustomerBlank_DefaultConstructor_IsNotNull()
        {
            // Arrange
            Customer sut;

            // Act
            sut = new Customer();

            // Assert
            Assert.IsNotNull(sut, "Blank Customer Default Constructor Is Not Null");
        }

        [TestMethod]
        public void CustomerCarryout_ParameterConstructor_IsNotNull()
        {
            // Arrange
            string name = "persons name";


            Customer sut;

            // Act
            sut = new Customer(name);

            // Assert
            Assert.IsNotNull(sut, "Carryout Customer Parameter Constructor Is Not Null");
        }

        [TestMethod]
        public void CustomerDelivery_ParameterConstructor_IsNotNull()
        {
            // Arrange
            string name = "persons name";
            string street = "street name";
            string city = "city name";
            int zipcode = 12345;

            Customer sut;

            // Act
            sut = new Customer(name, street, city, zipcode);

            // Assert
            Assert.IsNotNull(sut, "Delivery Customer Parameter Constructor Is Not Null");
        }

        [TestMethod]
        public void CustomerBlank_DefaultConstructor_AccessorMethods()
        {
            // Arrange
            string name = null;
            string street = null;
            string city = null;
            int zipcode = 0;

            Customer sut;

            // Act
            sut = new Customer();

            // Assert
            Assert.AreEqual(name, sut.CName, "Blank Customer public CName Accessor method is working properly.");
            Assert.AreEqual(street, sut.CStreet, "Blank Customer public CStreet Accessor method is working properly.");
            Assert.AreEqual(city, sut.CCity, "Blank Customer public CCity Accessor method is working properly.");
            Assert.AreEqual(zipcode, sut.CZipcode, "Blank Customer public CZipcode Accessor method is working properly.");
        }

        [TestMethod]
        public void CustomerCarryout_ParameterConstructor_AccessorMethods()
        {
            // Arrange
            string name = "customer name";

            Customer sut;

            // Act
            sut = new Customer(name);

            // Assert
            Assert.AreEqual(name, sut.CName, "Carryout Customer public Name Accessor method is working properly.");
        }

        [TestMethod]
        public void CustomerDelivery_ParameterConstructor_AccessorMethods()
        {
            // Arrange
            string name = "customer name";
            string street = "customer street";
            string city = "customer city";
            int zipcode = 0;

            Customer sut;

            // Act
            sut = new Customer(name, street, city, zipcode);

            // Assert
            Assert.AreEqual(name, sut.CName, "Delivery Customer public CName Accessor method is working properly.");
            Assert.AreEqual(street, sut.CStreet, "Delivery Customer public CStreet Accessor method is working properly.");
            Assert.AreEqual(city, sut.CCity, "Delivery Customer public CCity Accessor method is working properly.");
            Assert.AreEqual(zipcode, sut.CZipcode, "Delivery Customer public CZipcode Accessor method is working properly.");
        }

        [TestMethod]
        public void CustomerBlank_DefaultConstructor_MutatorMethods()
        {
            // Arrange
            string name = "customer name";
            string street = "customer street";
            string city = "customer city";
            int zipcode = 0;

            Customer sut = new Customer();

            // Act
            sut.CName = name;
            sut.CStreet = street;
            sut.CCity = city;
            sut.CZipcode = zipcode;

            // Assert
            Assert.AreEqual(name, sut.CName, "Blank Customer public CName Accessor method is working properly.");
            Assert.AreEqual(street, sut.CStreet, "Blank Customer public CStreet Accessor method is working properly.");
            Assert.AreEqual(city, sut.CCity, "Blank Customer public CCity Accessor method is working properly.");
            Assert.AreEqual(zipcode, sut.CZipcode, "Blank Customer public CZipcode Accessor method is working properly.");
        }

        [TestMethod]
        public void CustomerCarryout_ParameterConstructor_MutatorMethods()
        {
            // Arrange
            string name = "customer name";

            Customer sut = new Customer();

            // Act
            sut.CName = name;

            // Assert
            Assert.AreEqual(name, sut.CName, "Carryout Customer public CName Accessor method is working properly.");
        }

        [TestMethod]
        public void CustomerDelivery_DefaultConstructor_MutatorMethods()
        {
            // Arrange
            string name = "customer name";
            string street = "customer street";
            string city = "customer city";
            int zipcode = 0;

            Customer sut = new Customer();

            // Act
            sut.CName = name;
            sut.CStreet = street;
            sut.CCity = city;
            sut.CZipcode = zipcode;

            // Assert
            Assert.AreEqual(name, sut.CName, "Delivery Customer public CName Accessor method is working properly.");
            Assert.AreEqual(street, sut.CStreet, "Delivery Customer public CStreet Accessor method is working properly.");
            Assert.AreEqual(city, sut.CCity, "Delivery Customer public CCity Accessor method is working properly.");
            Assert.AreEqual(zipcode, sut.CZipcode, "Delivery Customer public CZipcode Accessor method is working properly.");
        }
    }
}
