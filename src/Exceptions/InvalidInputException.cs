using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace safe_code_demo.Exceptions
{
    [Serializable]
    public class InvalidInputException:Exception
    {
        public InvalidInputException(string message):base(message)
        {
            
        }
    }
}