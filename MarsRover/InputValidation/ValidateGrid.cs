using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExplorer.InputValidation
{
    public static class ValidateGrid
    {
        //Used to validate input from the user for the ExplorationGrid class. Valid input syntax for this class is two integers that are separated by a single space (e.g. "3 3").
        public static bool IsValid(string input)
        {
            string[] ValidationTest = input.Trim().Split(" ");
            try
            {
                if (int.Parse(ValidationTest[0]) < 2 || int.Parse(ValidationTest[1]) < 2)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

            return ValidationTest.Length == 2;
        }
    }
}

