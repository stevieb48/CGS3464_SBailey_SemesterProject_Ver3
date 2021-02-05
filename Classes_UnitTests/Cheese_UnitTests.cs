// @author: Stephen Bailey
// course: CGS3464
// assignment: final project
// date: 10/08/2018
// file name: Cheese_UnitTests.cs
// @version: 1.0
//
// Description
// This includes tests for the 'Cheese' class.

using Classes;
using EnumLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes_UnitTests
{
    [TestClass]

    public class Cheese_UnitTests
    {
        [TestMethod]
        public void Cheese_DefaultConstructor_IsNotNull()
        {
            // Arrange
            Cheese sut;

            // Act
            sut = new Cheese();

            // Assert
            Assert.IsNotNull(sut, "Cheese Default Constructor Is Not Null");
        }

        [TestMethod]
        public void Cheese_ParameterConstructor_IsNotNull()
        {
            // Arrange
            double price = 1.2;
            CheeseTypeList type = CheeseTypeList.Cheddar;

            Cheese sut;

            // Act
            sut = new Cheese(price, type);

            // Assert
            Assert.IsNotNull(sut, "Cheese Parameter Constructor Is Not Null");
        }

        [TestMethod]
        public void Cheese_DefaultConstructor_IsInstanceOfType_Item()
        {
            // Arrange
            Cheese sut;

            // Act
            sut = new Cheese();

            // Assert
            Assert.IsInstanceOfType(sut, typeof(Item), "Cheese default constructor is of type 'Item'.");
        }

        [TestMethod]
        public void Cheese_ParameterConstructor_IsInstanceOfType_Item()
        {
            // Arrange
            double price = 1.2;
            CheeseTypeList type = CheeseTypeList.Cheddar;

            Cheese sut;

            // Act
            sut = new Cheese(price, type);

            // Assert
            Assert.IsInstanceOfType(sut, typeof(Item), "Cheese parameter constructor is of type 'Item'.");
        }

        [TestMethod]
        public void Cheese_DefaultConstructor_AccessorMethods()
        {
            // Arrange
            double price = 0;

            Cheese sut;

            // Act
            sut = new Cheese();

            // Assert
            Assert.AreEqual(price, sut.IPrice, "Cheese public IPrice Accessor method is working properly.");
        }

        [TestMethod]
        public void Cheese_ParameterConstructor_AccessorMethods()
        {
            // Arrange
            double price = 3;

            Cheese sut;

            // Act
            sut = new Cheese(price, CheeseTypeList.Cheddar);

            // Assert
            Assert.AreEqual(price, sut.IPrice, "Cheese public IPrice Accessor method is working properly.");
        }

        [TestMethod]
        public void Cheese_DefaultConstructor_MutatorMethods()
        {
            // Arrange
            double newPrice = 4;

            Cheese sut = new Cheese();

            // Act
            sut.IPrice = newPrice;

            // Assert
            Assert.AreEqual(newPrice, sut.IPrice, "Cheese public IPrice Mutator method is working properly.");
        }

        [TestMethod]
        public void Cheese_ParameterConstructor_MutatorMethods()
        {
            // Arrange
            double oldPrice = 3;
            double newPrice = 4;

            Cheese sut = new Cheese(oldPrice, CheeseTypeList.Cheddar);

            // Act
            sut.IPrice = newPrice;

            // Assert
            Assert.AreEqual(newPrice, sut.IPrice, "Cheese public IPrice Mutator method is working properly.");
        }
    }
}
