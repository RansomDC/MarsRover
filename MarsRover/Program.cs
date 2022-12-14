using MarsExplorer.InputValidation;
using System;

namespace MarsExplorer
{
    public class Program
    {
        static void Main(string[] args)
        {
            // *** Request input from user of the size of the grid that is to be explored by the rover. Validate the input, and re-request if input is invalid. *** \\
            Console.WriteLine("Please describe the size of the exploration grid with the Northeastern most point (e.g. \"3 3\" will create a 3x3 grid).");
            var gridInput = Console.ReadLine();

            // Validate input with the IsValid method from Explorationgrid class.
            bool gridValid = ValidateGrid.IsValid(gridInput);
            while (!gridValid)
            {
                Console.WriteLine("Invalid Input: Please enter only two, single-space separated, positive integers greater than 1 (e.g. \"3 3\")");
                gridInput = Console.ReadLine();
                gridValid = ValidateGrid.IsValid(gridInput);
            }
            // Once grid values are valid, create the new ExplorationGrid
            var plateauSurface = new ExplorationGrid(gridInput);


            // *** Requrest location and direction of the first Rover. Get input from user. Validate the input, and re-request if input is invalid *** \\
            Console.WriteLine("Please describe the location on the grid of the rover and the direction it is facing (e.g. \"2 2 N\").");
            var firstLocation = Console.ReadLine();

            // Validate input with the IsValidInput method.
            bool firstlocationValid = ValidateLocation.IsValid(firstLocation, plateauSurface);
            while (!firstlocationValid)
            {
                Console.WriteLine("Invalid Input: Please enter two, single-space separated, positive integers and one of the four cardinal directions (NSEW) (e.g. \"2 2 N\")");
                firstLocation = Console.ReadLine();
                firstlocationValid = ValidateLocation.IsValid(firstLocation, plateauSurface);
            }
            // Once location is valid, create the new MarsRover
            var roverOne = new MarsRover(firstLocation, plateauSurface);


            // *** Request instructions for the first Rover. Get input from user. Validate the input, and re-request if input is invalid *** \\
            Console.WriteLine("Please enter a series of instructions (no spaces) for the first Rover using R or L to turn right or left, or M to move forward (e.g. \"MLMR\").");
            var roverOneInstructions = Console.ReadLine();
            bool roverOnevalid = ValidateInstructions.IsValid(roverOneInstructions);
            while (!roverOnevalid)
            {
                Console.WriteLine("Invalid Input: Please enter a combination of only L, R, or M and do not use spaces (e.g. \"LMRM\").");
                roverOneInstructions = Console.ReadLine();
                roverOnevalid = ValidateInstructions.IsValid(roverOneInstructions);
            }


            // *** Requrest location and direction of the second Rover. Get input from user. Validate the input, and re-request if input is invalid *** \\
            Console.WriteLine("Please describe the location on the grid of the rover and the direction it is facing (e.g. \"2 2 N\").");
            var secondLocation = Console.ReadLine();

            // Validate input with the IsValidInput method.
            bool secondLocationValid = ValidateLocation.IsValid(secondLocation, plateauSurface);
            while (!secondLocationValid)
            {
                Console.WriteLine("Invalid Input: Please enter two, single-space separated, positive integers and one of the four cardinal directions (NSEW) (e.g. \"2 2 N\")");
                secondLocation = Console.ReadLine();
                secondLocationValid = ValidateLocation.IsValid(secondLocation, plateauSurface);
            }
            // Once location is valid, create the new MarsRover
            var roverTwo = new MarsRover(secondLocation, plateauSurface);


            // *** Request instructions for the second Rover. Get input from user. Validate the input, and re-request if input is invalid *** \\
            Console.WriteLine("Please enter a series of instructions (no spaces) for the first Rover using R or L to turn right or left, or M to move forward (e.g. \"MLMR\").");
            var roverTwoInstructions = Console.ReadLine();
            bool roverTwovalid = ValidateInstructions.IsValid(roverTwoInstructions);
            while (!roverTwovalid)
            {
                Console.WriteLine("Invalid Input: Please enter a combination of only L, R, or M and do not use spaces (e.g. \"LMRM\").");
                roverTwoInstructions = Console.ReadLine();
                roverTwovalid = ValidateInstructions.IsValid(roverTwoInstructions);
            }

            // Execute RoverOne and RoverTwo instructions and print the ending locations
            Console.WriteLine("Rover One location:");
            Console.WriteLine(roverOne.ExecuteInstructions(roverOneInstructions));
            Console.WriteLine("Rover Two location:");
            Console.WriteLine(roverTwo.ExecuteInstructions(roverTwoInstructions));


            // Test Input:
            // 5 5
            // 1 2 N
            // LMLMLMLMM
            // 3 3 E
            // MMRMMRMRRM
        }
    }
}