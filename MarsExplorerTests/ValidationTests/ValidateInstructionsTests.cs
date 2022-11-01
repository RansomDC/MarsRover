using MarsExplorer;
using MarsExplorer.InputValidation;

namespace MarsExplorerTests.ValidationTests
{
    [TestClass]
    public class ValidateInstructionsTests
    {
        [TestMethod]
        public void ValidateInstructions_ValidInput_ReturnsTrue()
        {
            //Arrange
            string validInput = "LMRMLMLMR";
            bool expected = true;

            //Act
            bool actual = ValidateInstructions.IsValid(validInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateInstructions_ValidLowerCaseInput_ReturnsTrue()
        {
            //Arrange
            string validInput = "lmrmlmlmr";
            bool expected = true;

            //Act
            bool actual = ValidateInstructions.IsValid(validInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateInstructions_Empty_ReturnsTrue()
        {
            //Arrange
            string invalidInput = "";
            bool expected = true;

            //Act
            bool actual = ValidateInstructions.IsValid(invalidInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateInstructions_NonLMRInput_ReturnsFalse()
        {
            //Arrange
            string invalidInput = "LMUMM";
            bool expected = false;

            //Act
            bool actual = ValidateInstructions.IsValid(invalidInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}