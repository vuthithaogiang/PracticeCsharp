using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.exception
{
    internal class InvalidRadiusException : Exception
    {

        public double InvalidRadius { get; set; }
        public InvalidRadiusException() : base() { }
        public InvalidRadiusException(string message) : base(message) { }
        public InvalidRadiusException(string message, Exception innerException) : base(message, innerException) { }
        public InvalidRadiusException(string message, double radius) : base(message)
        {
            InvalidRadius = radius;
        }

        public override string ToString()
        {
            return base.ToString() + "\nRadius is invalid: " + InvalidRadius;
        }
    }
}
