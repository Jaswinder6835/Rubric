using System;

namespace Assignment01.Exceptions
{
    public class LessThanZeroException : Exception
    {
        public LessThanZeroException(string rectangleAttribute): base(rectangleAttribute + " value should be greater than zero.")
        {

        }
    }
}
