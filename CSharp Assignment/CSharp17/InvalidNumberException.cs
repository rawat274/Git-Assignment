using System;

namespace CSharp17
{

    class InvalidNumberException : Exception
    {
        public InvalidNumberException(string a)
            : base(a) { }
    }
}

