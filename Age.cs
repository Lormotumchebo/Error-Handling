using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling
{
    internal class Age
    {
        

// 1. Define the custom exception class
public class InvalidAgeException : Exception
    {
        public InvalidAgeException() : base("Invalid age. Age must be a positive integer.") { } // Default constructor
        public InvalidAgeException(string message) : base(message) { } // Constructor with a custom message
        public InvalidAgeException(string message, Exception innerException) : base(message, innerException) { } // Constructor with inner exception
    }

    public class Person
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidAgeException(); // Throw the custom exception
                }
                _age = value;
            }
        }

        public Person(int age)
        {
            Age = age; // Use the property setter to trigger the exception if needed.
        }
    }

   
}
}
