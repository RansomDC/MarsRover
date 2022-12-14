using MarsExplorer.Enums;
using MarsExplorer.InputValidation;

namespace MarsExplorer
{
    public class MarsRover
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Cardinal Direction { get; set; }
        public ExplorationGrid plateau { get; set; }

        // The basic constructors that would take all of the required inputs for the Rover
        public MarsRover(int X, int Y, string Z, ExplorationGrid Plateau)
        {
            XCoordinate = X;
            YCoordinate = Y;
            Direction = Enum.Parse<Cardinal>(Z);
            plateau = Plateau;
        }

        // This constructor takes and parses a string input for the values in the user input. It is meant to be checked with the ValidateLocation class. This constructor is created in order to neaten the Main() Program code.
        public MarsRover(string input, ExplorationGrid Plateau)
        {
            string[] location = input.ToUpper().Trim().Split(" ");

            XCoordinate = int.Parse(location[0]);
            YCoordinate = int.Parse(location[1]);
            Direction = Enum.Parse<Cardinal>(location[2]);
            plateau = Plateau;
        }

        private string GetLocationString()
        {
            return $"{XCoordinate} {YCoordinate} {Direction}";
        }

        // Iterate a list of instructions and execute each one.
        public string ExecuteInstructions(string input)
        {
            // We validate the input here so that if this method is ever called without validating in the UI the input will return more useful information
            foreach (char instruction in input.ToUpper())
            {
                if (instruction == 'L')
                {
                    Left();
                }
                else if (instruction == 'R')
                {
                    Right();
                }
                else if (instruction == 'M')
                {
                    Maintain();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            return GetLocationString();
        }

        // Rotate the rover to the right without moving.
        private void Left()
        {
            if (Direction == Cardinal.N)
            {
                Direction = Cardinal.W;
            }
            else
            {
                Direction--;
            }
        }

        // Rotate the rover to the right without moving.
        private void Right()
        {
            if (Direction == Cardinal.W)
            {
                Direction = Cardinal.N;
            }
            else
            {
                Direction++;
            }
        }

        // Move forward one space assuming the rover is not at the end of the grid
        private void Maintain()
        {
            if (Direction == Cardinal.N)
            {
                if (YCoordinate < plateau.YAxisMax)
                {
                    YCoordinate++;
                }
            }
            else if (Direction == Cardinal.E)
            {
                if (XCoordinate < plateau.XAxisMax)
                {
                    XCoordinate++;
                }
            }
            else if (Direction == Cardinal.S)
            {
                if (YCoordinate > 0)
                {
                    YCoordinate--;
                }
            }
            else
            {
                if (XCoordinate > 0)
                {
                    XCoordinate--;
                }
            }
        }
    }
}
