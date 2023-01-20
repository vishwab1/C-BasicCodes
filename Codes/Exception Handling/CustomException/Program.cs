using System;
using System.Text.RegularExpressions;
using CSharp;
internal class Program
{
    private static void ValidateStudent(Employee std)
    {
        Regex regex = new Regex("^[a-zA-Z]+$");

        if (!regex.IsMatch(std.Name))
            throw new InvalidStudentNameException(std.Name);

    }
    static void Main(string[] args)
    {
        Employee newStudent = null;

        try
        {
            newStudent = new Employee();
            newStudent.Name = "vishwa123";

            ValidateStudent(newStudent);
        }
        catch (InvalidStudentNameException ex)
        {
            Console.WriteLine(ex.Message);
        }


       
    }


}
    
