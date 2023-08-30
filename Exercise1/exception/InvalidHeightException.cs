using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.exception
{
    internal class InvalidHeightException : Exception
    {

        public double InvalidHeight { get; set; }
        public InvalidHeightException() : base() { }
        public InvalidHeightException(string message) : base(message) { }
        public InvalidHeightException(string message, Exception innerException) : base(message, innerException) { }
        public InvalidHeightException(string message, double height) : base(message)
        {
            InvalidHeight = height;
        }

        public override string ToString()
        {
            return base.ToString() + "\nHeight is invalid: " + InvalidHeight;
        }
    }
}
