using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExplorer
{
    public class MarsRover : Rover
    {
        public ExplorationGrid plateau { get; set; }

        // The basic constructors that would take all of the required inputs for the Rover
        public MarsRover(int X, int Y, string Z, ExplorationGrid Plateau)
        {
            XCoordinate = X;
            YCoordinate = Y;
            Direction = Enum.Parse<Cardinal>(Z);
            plateau = Plateau;
        }

        // This constructor takes and parses a string input for the values in the user input. It is meant to be checked with the ValidateRoverLocation class. This constructor is created in order to neaten the Main() Program code.
        public MarsRover(string input, ExplorationGrid Plateau)
        {
            string[] location = input.ToUpper().Trim().Split(" ");

            XCoordinate = int.Parse(location[0]);
            YCoordinate = int.Parse(location[1]);
            Direction = Enum.Parse<Cardinal>(location[2]);
            plateau = Plateau;
        }

        public void ExecuteInstructions(string input)
        {
            // We validate the input here so that if this method is ever called without validating in the UI the input will return more useful information
            if (ValidateInstructions(input))
            {
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
                    else
                    {
                        Maintain();
                    }
                }
                Console.WriteLine("{0} {1} {2}\n", XCoordinate, YCoordinate, Direction);
            }
            else
            {
                throw new ArgumentException();
            }

        }

        //Used to validate input from the user for the ExplorationGrid class. Valid input syntax for this class is two integers that are separated by a single space (e.g. "3 3").
        public static bool IsValidInput(string input, ExplorationGrid grid)
        {
            string[] ValidationTest = input.ToUpper().Trim().Split(" ");
            try
            {
                if (int.Parse(ValidationTest[0]) < 0 ||
                    int.Parse(ValidationTest[1]) < 0 ||
                    int.Parse(ValidationTest[0]) > grid.GridWidth ||
                    int.Parse(ValidationTest[1]) > grid.GridHeight)
                {
                    Console.WriteLine("Your input did not match the exploration grid's parameters.");
                    return false;
                }
                else if (ValidationTest[2] != "N" &&
                    ValidationTest[2] != "E" &&
                    ValidationTest[2] != "S" &&
                    ValidationTest[2] != "W")
                {
                    Console.WriteLine("Your third input needs to be one of the cardinal directions (e.g. N, S, E or W).");
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

            return ValidationTest.Length == 3;
        }

        public void Left()
        {
            if(Direction == Cardinal.N)
            {
                Direction = Cardinal.W;
            }
            else
            {
                Direction--;
            }
        }

        public void Right()
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

        public void Maintain()
        {
            if(Direction == Cardinal.N)
            {
                if(YCoordinate < plateau.GridHeight)
                {
                    YCoordinate++;
                }
            }
            else if(Direction == Cardinal.E)
            {
                if (XCoordinate < plateau.GridWidth)
                {
                    XCoordinate++;
                }
            }
            else if(Direction == Cardinal.S)
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

        public static bool ValidateInstructions(string input)
        {
            foreach(char instruction in input.ToUpper())
            {
                if(instruction != 'L' && instruction != 'R' && instruction != 'M')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
