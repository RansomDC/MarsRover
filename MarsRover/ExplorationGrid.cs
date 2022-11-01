using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExplorer
{
    public class ExplorationGrid
    {
        public int GridWidth { get; set; }
        public int GridHeight { get; set; }


        // The basic constructors that would take all of the normal required inputs for the an ExplorationGrid
        public ExplorationGrid(int Width, int Height)
        {
            GridHeight = Height;
            GridWidth = Width;
        }

        // This constructor takes and parses a string input for the values in the user input. It is meant to be checked with the ValidateExplorationGrid class. This constructor is created in order to neaten the Main() Program code.
        public ExplorationGrid(string input)
        {
            string[] inputs = input.Trim().Split(" ");

            GridWidth = int.Parse(inputs[0]);
            GridHeight = int.Parse(inputs[1]);
        }

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
}
