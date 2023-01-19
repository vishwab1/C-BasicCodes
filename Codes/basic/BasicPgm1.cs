using System;

using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


public class Calculate
{


    internal class BasicPgm1
    {
        static void Square(int a, int b)
        {
            a = a * a;
            b = b * b;
            Console.WriteLine(a + " " + b);
        }

        private static void Main(string[] args)
        {
         

                int num1 = 5;
                int num2 = 10;
                Console.WriteLine(num1 + " " + num2);
                Square(num1, num2);
                Console.WriteLine(num1 + " " + num2);

            


        }
    }
}
 

    





    

