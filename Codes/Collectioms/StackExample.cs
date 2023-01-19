using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;





internal class StackExample
    {


        private static void Main(string[] args)
        {
        Stack stk = new Stack();
        stk.Push("Vishwa");
        stk.Push(10);
        stk.Push(10.1);
        foreach (var item in stk)
        {
            Console.WriteLine(item);
        }

        stk.Pop();
        Console.WriteLine("after pop");
        foreach (var item in stk)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Method peek"+stk.Peek);






    }
}

 

    





    

