// @author: Stephen Bailey
// course: CGS3464
// assignment: final project
// date: 10/08/2018
// file name: Order_UnitTests.cs
// @version: 1.0
//
// Description
// This includes tests for the 'Order' class.

using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes_UnitTests
{
    [TestClass]

    public class Order_UnitTests
    {
        [TestMethod]
        public void Order_ParameterConstructor_IsNotNull()
        {
            // Arrange
            int ordernumber = 1;

            Order sut;

            // Act
            sut = new Order(ordernumber);

            // Assert
            Assert.IsNotNull(sut, "Order Customer Parameter Constructor Is Not Null");
        }

        [TestMethod]
        public void Order_ParameterConstructor_AccessorMethods()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        public void Order_ParameterConstructor_MutatorMethods()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        public void Order_Calculate_Subtotal()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        public void Order_Calculate_DeliveryCharge()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        public void Order_Calculate_Tax()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        public void Order_Calculate_Total()
        {
            // Arrange

            // Act

            // Assert

        }
    }
}
