using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

// @author: Stephen Bailey
// course: CGS3464
// assignment: final project
// date: 10/08/2018
// file name: ValidationTools_UnitTests.cs
// @version: 1.0
//
// Description
// This includes tests for the 'ValidationTools' class.

namespace Classes_UnitTests
{
    [TestClass]
    public class ValidationTools_UnitTests
    {
        [TestMethod]
        public void ValidationTools_IsValInputString_PassingValue()
        {
            // Arrange
            string TestString = "F";

            ValidationTools sut = new ValidationTools();

            // Act
            bool result = sut.IsValInputString(TestString);

            // Assert
            Assert.IsTrue(result, "ValidationTools IsValInputString method with a passing letter value works");
        }

        [TestMethod]
        public void ValidationTools_IsValInputString_BlankValue()
        {
            // Arrange
            string TestString = " ";

            ValidationTools sut = new ValidationTools();

            // Act
            bool result = sut.IsValInputString(TestString);

            // Assert
            Assert.IsFalse(result, "ValidationTools IsValInputString method with a blank value fails");
        }

        [TestMethod]
        public void ValidationTools_IsValInputString_SpecialCharacterValue()
        {
            // Arrange
            string TestString = "@";

            ValidationTools sut = new ValidationTools();

            // Act
            bool result = sut.IsValInputString(TestString);

            // Assert
            Assert.IsFalse(result, "ValidationTools IsValInputString method with a special character value fails");
        }

        [TestMethod]
        public void ValidationTools_IsValInputString_NumberValue()
        {
            // Arrange
            string TestString = "2";

            ValidationTools sut = new ValidationTools();

            // Act
            bool result = sut.IsValInputString(TestString);

            // Assert
            Assert.IsFalse(result, "ValidationTools IsValInputString method with a number value fails");
        }

        [TestMethod]
        public void ValidationTools_IsValInputNumber_PassingValue()
        {
            // Arrange
            string TestString = "2";

            ValidationTools sut = new ValidationTools();

            // Act
            bool result = sut.IsValInputNumber(TestString);

            // Assert
            Assert.IsTrue(result, "ValidationTools IsValInputNumber method with a passing number value works");
        }

        [TestMethod]
        public void ValidationTools_IsValInputNumber_BlankValue()
        {
            // Arrange
            string TestString = " ";

            ValidationTools sut = new ValidationTools();

            // Act
            bool result = sut.IsValInputNumber(TestString);

            // Assert
            Assert.IsFalse(result, "ValidationTools IsValInputNumber method with a blank value fails");
        }

        [TestMethod]
        public void ValidationTools_IsValInputNumber_SpecialCharacterValue()
        {
            // Arrange
            string TestString = "!";

            ValidationTools sut = new ValidationTools();

            // Act
            bool result = sut.IsValInputNumber(TestString);

            // Assert
            Assert.IsFalse(result, "ValidationTools IsValInputNumber method with a special character value fails");
        }

        [TestMethod]
        public void ValidationTools_IsValInputNumbe_LetterValue()
        {
            // Arrange
            string TestString = "e";

            ValidationTools sut = new ValidationTools();

            // Act
            bool result = sut.IsValInputNumber(TestString);

            // Assert
            Assert.IsFalse(result, "ValidationTools IsValInputNumber method with a letter value fails");
        }
    }
}
