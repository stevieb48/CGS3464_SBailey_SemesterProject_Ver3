// @author: Stephen Bailey
// course: CGS3464
// assignment: final project
// date: 10/08/2018
// file name: Crust_UnitTests.cs
// @version: 1.0
//
// Description
// This includes tests for the 'Crust' class.

using Classes;
using EnumLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes_UnitTests
{
    [TestClass]

    public class Crust_UnitTests
    {
        [TestMethod]
        public void Crust_DefaultConstructor_IsNotNull()
        {
            // Arrange
            Crust sut;

            // Act
            sut = new Crust();

            // Assert
            Assert.IsNotNull(sut, "Crust Default Constructor Is Not Null");
        }

        [TestMethod]
        public void Crust_ParameterConstructor_IsNotNull()
        {
            // Arrange
            double price = 1.2;
            CrustTypeList type = CrustTypeList.Pan;

            Crust sut;

            // Act
            sut = new Crust(price, type);

            // Assert
            Assert.IsNotNull(sut, "Crust Parameter Constructor Is Not Null");
        }

        [TestMethod]
        public void Crust_DefaultConstructor_IsInstanceOfType_Item()
        {
            // Arrange
            Crust sut;

            // Act
            sut = new Crust();

            // Assert
            Assert.IsInstanceOfType(sut, typeof(Item), "Crust default constructor is of type 'Item'.");
        }

        [TestMethod]
        public void Crust_ParameterConstructor_IsInstanceOfType_Item()
        {
            // Arrange
            double price = 1.2;
            CrustTypeList type = CrustTypeList.Pan;

            Crust sut;

            // Act
            sut = new Crust(price, type);

            // Assert
            Assert.IsInstanceOfType(sut, typeof(Item), "Crust parameter constructor is of type 'Item'.");
        }

        [TestMethod]
        public void Crust_DefaultConstructor_AccessorMethods()
        {
            // Arrange
            double price = 0;

            Crust sut;

            // Act
            sut = new Crust();

            // Assert
            Assert.AreEqual(price, sut.IPrice, "Crust public IPrice Accessor method is working properly.");
        }

        [TestMethod]
        public void Crust_ParameterConstructor_AccessorMethods()
        {
            // Arrange
            double price = 3;

            Crust sut;

            // Act
            sut = new Crust(price, CrustTypeList.Pan);

            // Assert
            Assert.AreEqual(price, sut.IPrice, "Crust public IPrice Accessor method is working properly.");
        }

        [TestMethod]
        public void Crust_DefaultConstructor_MutatorMethods()
        {
            // Arrange
            double newPrice = 4;

            Crust sut = new Crust();

            // Act
            sut.IPrice = newPrice;

            // Assert
            Assert.AreEqual(newPrice, sut.IPrice, "Crust public IPrice Mutator method is working properly.");
        }

        [TestMethod]
        public void Crust_ParameterConstructor_MutatorMethods()
        {
            // Arrange
            double oldPrice = 3;
            double newPrice = 4;

            Crust sut = new Crust(oldPrice, CrustTypeList.Pan);

            // Act
            sut.IPrice = newPrice;

            // Assert
            Assert.AreEqual(newPrice, sut.IPrice, "Crust public IPrice Mutator method is working properly.");
        }
    }
}
