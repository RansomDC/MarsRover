using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExplorer.InputValidation
{
    internal class ValidateInstructions
    {
        public static bool IsValid(string input)
        {
            foreach (char instruction in input.ToUpper())
            {
                if (instruction != 'L' && instruction != 'R' && instruction != 'M')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
