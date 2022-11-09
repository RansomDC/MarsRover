using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExplorer.InputValidation
{
    public class ValidateLocation
    {
        //Used to validate input from the user for the ExplorationGrid class. Valid input syntax for this class is two integers that are separated by a single space (e.g. "3 3").
        public static bool IsValid(string input, ExplorationGrid grid)
        {
            var adjustedInput = input.ToUpper().Trim();
            string[] ValidationTest = adjustedInput.Split(" ");
            try
            {
                if (int.Parse(ValidationTest[0]) < 0 ||
                    int.Parse(ValidationTest[1]) < 0 ||
                    int.Parse(ValidationTest[0]) > grid.XAxisMax ||
                    int.Parse(ValidationTest[1]) > grid.YAxisMax)
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
    }
}
