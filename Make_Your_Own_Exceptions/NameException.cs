using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionClass
{
    class NameException : Exception
    {
        public override string Message
        {
            get
            {
                return "Name is invalid as it doesn't has first letter capital or it contain special character in it";
            }
        }
    }
}
