using System;

namespace ExceptionClass
{
    class AgeException : Exception
    {
        public override string Message
        {
            get
            {
                return "Age is invalid";
            }
        }
    }
}
