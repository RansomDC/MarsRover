using MarsExplorer.InputValidation;
using MarsExplorer;

namespace MarsExplorerTests.ValidationTests
{
    [TestClass]
    public class ValidateLocationTests
    {
        [TestMethod]
        public void ValidateLocation_ValidInput_ReturnsTrue()
        {
            //Arrange
            string validInput = "0 0 N";
            bool expected = true;
            ExplorationGrid grid = new ExplorationGrid(5, 5);

            //Act
            bool actual = ValidateLocation.IsValid(validInput, grid);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateLocation_SpaceSurrounded_ReturnsTrue()
        {
            //Arrange
            string validInput = " 0 0 N ";
            bool expected = true;
            ExplorationGrid grid = new ExplorationGrid(5, 5);

            //Act
            bool actual = ValidateLocation.IsValid(validInput, grid);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateLocation_InvalidDirection_ReturnsFalse()
        {
            //Arrange
            string validInput = "0 0 U";
            bool expected = false;
            ExplorationGrid grid = new ExplorationGrid(5, 5);

            //Act
            bool actual = ValidateLocation.IsValid(validInput, grid);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateLocation_InvalidGridspace_ReturnsFalse()
        {
            //Arrange
            string validInput = "0 6 N";
            bool expected = false;
            ExplorationGrid grid = new ExplorationGrid(5, 5);

            //Act
            bool actual = ValidateLocation.IsValid(validInput, grid);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateLocation_NoSpacing_ReturnsFalse()
        {
            //Arrange
            string validInput = "00N";
            bool expected = false;
            ExplorationGrid grid = new ExplorationGrid(5, 5);

            //Act
            bool actual = ValidateLocation.IsValid(validInput, grid);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateLocation_MultipleSpaces_ReturnsFalse()
        {
            //Arrange
            string validInput = "0  0  N";
            bool expected = false;
            ExplorationGrid grid = new ExplorationGrid(5, 5);

            //Act
            bool actual = ValidateLocation.IsValid(validInput, grid);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateLocation_NonIntGridLocation_ReturnsFalse()
        {
            //Arrange
            string validInput = "F 0 N";
            bool expected = false;
            ExplorationGrid grid = new ExplorationGrid(5, 5);

            //Act
            bool actual = ValidateLocation.IsValid(validInput, grid);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateLocation_EmptyString_ReturnsFalse()
        {
            //Arrange
            string validInput = "";
            bool expected = false;
            ExplorationGrid grid = new ExplorationGrid(5, 5);

            //Act
            bool actual = ValidateLocation.IsValid(validInput, grid);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
