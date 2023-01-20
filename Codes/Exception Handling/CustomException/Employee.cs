using System;


namespace CSharp
{
    internal class Employee
    {

        public string Name { get; set; }
    }

    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() { }

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {

        }
    }
}
