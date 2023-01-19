using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class SwitchStatement
    {
        private static void Main(string[] args)
        {
        int x = 15;
        switch (x)
        {
            case 10:
                Console.WriteLine("x value is 10");
                break;
            case 15:
                Console.WriteLine("x value is 15");
                break;
            case 20:
                Console.WriteLine("x value is 20");
                break;
            default:
                Console.WriteLine("Not Known");
                break;
        }



    }




}
    

