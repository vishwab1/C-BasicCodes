using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class MethodsParamPgm
{

    private static void Main(string[] args)
    {

        ParamsMethod(1, 2, 3, 4, 5, 6,8);
    }

        public static void ParamsMethod(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : ""));
            }
            Console.WriteLine();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }

}


 

    





    

