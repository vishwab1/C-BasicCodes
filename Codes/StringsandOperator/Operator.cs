using System;
using System.Text;

internal class Operator
{

    static void Main(string[] args)
    {
        //Arithmatic Operator
        int result;
        int x = 20, y = 10;
        result = (x + y);
        Console.WriteLine("Addition Operator: " + result);
        result = (x - y);
        Console.WriteLine("Subtraction Operator: " + result);
        result = (x * y);
        Console.WriteLine("Multiplication Operator: " + result);
        result = (x / y);
        Console.WriteLine("Division Operator: " + result);
        result = (x % y);
        Console.WriteLine("Modulo Operator: " + result);


        //Relational 
        bool result1;
        int a = 10, b = 20;
        result1 = (a == b);
        Console.WriteLine("Equal to Operator: " + result1);
        result1 = (a > b);
        Console.WriteLine("Greater than Operator: " + result1);
        result1 = (a <= b);
        Console.WriteLine("Lesser than or Equal to: " + result1);
        result1 = (a != b);
        Console.WriteLine("Not Equal to Operator: " + result1);
        
        //Logical Operator

        bool booly = true, result2;
        // AND operator
        result2 = (x <= y) && (x > 10);
        Console.WriteLine("AND Operator: " + result2);
        // OR operator
        result2 = (x >= y) || (x < 5);
        Console.WriteLine("OR Operator: " + result2);
        //NOT operator
        result2 = !booly;
        Console.WriteLine("NOT Operator: " + result2);
    }


}
    
