using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using safe_code_demo.Exceptions;

namespace safe_code_demo.Extensions
{
    public static class Validators
    {
        public static string ValidateInput(this string line)
        {
            if(string.IsNullOrEmpty(line))
                throw new InvalidInputException("input is null or empty");
            if(!Regex.IsMatch(line,Constants.INPUT_REGEX))
                throw new InvalidInputException("invalid input format");
            return line;
        }

        public static string ValidateOutput(this string csvLine)
        {
            if(string.IsNullOrEmpty(csvLine))
                throw new InvalidOutputException("input is null or empty");
            if(!Regex.IsMatch(csvLine,Constants.OUTPUT_REGEX))
                throw new InvalidOutputException("invalid output format");
            return csvLine;
        }
    }
}