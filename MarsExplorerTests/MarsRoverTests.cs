using MarsExplorer;
using MarsExplorer.InputValidation;

namespace MarsExplorerTests.ValidationTests
{
    [TestClass]
    public class MarsRoverTests
    {
        [TestMethod]
        public void GetLocationString_ValidInput_ReturnsTrue()
        {
            //Arrange
            ExplorationGrid grid = new ExplorationGrid(5, 5);
            MarsRover rover = new MarsRover(0, 0, "N", grid);
            string expected = "0 0 N";

            //Act
            string actual = rover.ExecuteInstructions("");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExecuteInstructions_ValidInput_ReturnsTrue()
        {
            //Arrange
            ExplorationGrid grid = new ExplorationGrid(5, 5);
            MarsRover rover = new MarsRover(0, 0, "N", grid);
            string expected = "1 2 E";

            //Act
            string actual = rover.ExecuteInstructions("MMRM");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Right_ValidInput_ReturnsTrue()
        {
            //Arrange
            ExplorationGrid grid = new ExplorationGrid(5, 5);
            MarsRover rover = new MarsRover(0, 0, "N", grid);
            string expected = "0 0 E";

            //Act
            string actual = rover.ExecuteInstructions("R");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Left_ValidInput_ReturnsTrue()
        {
            //Arrange
            ExplorationGrid grid = new ExplorationGrid(5, 5);
            MarsRover rover = new MarsRover(0, 0, "N", grid);
            string expected = "0 0 W";

            //Act
            string actual = rover.ExecuteInstructions("L");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaintainN_ValidInput_ReturnsTrue()
        {
            //Arrange
            ExplorationGrid grid = new ExplorationGrid(5, 5);
            MarsRover rover = new MarsRover(3, 3, "N", grid);
            string expected = "3 4 N";

            //Act
            string actual = rover.ExecuteInstructions("M");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaintainE_ValidInput_ReturnsTrue()
        {
            //Arrange
            ExplorationGrid grid = new ExplorationGrid(5, 5);
            MarsRover rover = new MarsRover(3, 3, "E", grid);
            string expected = "4 3 E";

            //Act
            string actual = rover.ExecuteInstructions("M");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaintainS_ValidInput_ReturnsTrue()
        {
            //Arrange
            ExplorationGrid grid = new ExplorationGrid(5, 5);
            MarsRover rover = new MarsRover(3, 3, "S", grid);
            string expected = "3 2 S";

            //Act
            string actual = rover.ExecuteInstructions("M");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaintainW_ValidInput_ReturnsTrue()
        {
            //Arrange
            ExplorationGrid grid = new ExplorationGrid(5, 5);
            MarsRover rover = new MarsRover(3, 3, "W", grid);
            string expected = "2 3 W";

            //Act
            string actual = rover.ExecuteInstructions("M");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}