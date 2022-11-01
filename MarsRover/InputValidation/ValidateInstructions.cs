using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExplorer.InputValidation
{
    public class ValidateInstructions
    {
        public static bool IsValid(string input)
        {
            if(input is null)
            {
                return false;
            }

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
