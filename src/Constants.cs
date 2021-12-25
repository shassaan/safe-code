using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace safe_code_demo
{
    public static class Constants
    {
        public const string INPUT_REGEX = "^[a-zA-Z]{1,}[;]{1}[a-zA-Z]{1,}[;]{1}[0-9]{11}$";
        public const string OUTPUT_REGEX = "^[a-zA-Z]{1,}[ ]{1}[a-zA-Z]{1,}[,]{1}[0-9]{11}$";
    }
}