using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExplorer
{
    public class ExplorationGrid
    {
        public int XAxisMax { get; set; }
        public int YAxisMax { get; set; }


        // The basic constructors that would take all of the normal required inputs for the an ExplorationGrid
        public ExplorationGrid(int Width, int Height)
        {
            YAxisMax = Height;
            XAxisMax = Width;
        }

        // This constructor takes and parses a string input for the values in the user input. It is meant to be checked with the ValidateExplorationGrid class. This constructor is created in order to neaten the Main() Program code.
        public ExplorationGrid(string input)
        {
            string[] inputs = input.Trim().Split(" ");

            XAxisMax = int.Parse(inputs[0]);
            YAxisMax = int.Parse(inputs[1]);
        }
    }
}

