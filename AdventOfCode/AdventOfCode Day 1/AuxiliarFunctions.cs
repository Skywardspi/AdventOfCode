using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_Day_1
{
    internal class AuxiliarFunctions
    {
        public static string CleanString(string input)
        {
            return input.ReplaceLineEndings("").Trim();
        }
    }
}
