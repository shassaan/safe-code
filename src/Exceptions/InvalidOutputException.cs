using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace safe_code_demo.Exceptions
{
    [Serializable]
    public class InvalidOutputException:Exception
    {
        public InvalidOutputException(string message):base(message)
        {
            
        }
    }
}