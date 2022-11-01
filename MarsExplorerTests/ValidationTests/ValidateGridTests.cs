using MarsExplorer;
using MarsExplorer.InputValidation;

namespace MarsExplorerTests.ValidationTests
{
    [TestClass]
    public class ValidateGridTests
    {
        [TestMethod]
        public void ValidateGrid_ValidInput_ReturnsTrue()
        {
            //Arrange
            string validInput = "5 5";
            bool expected = true;

            //Act
            bool actual = ValidateGrid.IsValid(validInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateGrid_SpacesBeforeAndAfter_ReturnsTrue()
        {
            //Arrange
            string validInput = " 5 5 ";
            bool expected = true;

            //Act
            bool actual = ValidateGrid.IsValid(validInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateGrid_TwoSpaces_ReturnsFalse()
        {
            //Arrange
            string validInput = "5  5";
            bool expected = false;

            //Act
            bool actual = ValidateGrid.IsValid(validInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateGrid_TooManyArgs_ReturnsFalse()
        {
            //Arrange
            string validInput = "5 5 5";
            bool expected = false;

            //Act
            bool actual = ValidateGrid.IsValid(validInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateGrid_NonNumericals_ReturnsFalse()
        {
            //Arrange
            string validInput = "5 n";
            bool expected = false;

            //Act
            bool actual = ValidateGrid.IsValid(validInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateGrid_Null_ReturnsFalse()
        {
            //Arrange
            string validInput = "";
            bool expected = false;

            //Act
            bool actual = ValidateGrid.IsValid(validInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}