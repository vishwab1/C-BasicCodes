using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


public class Calculate
{
    interface IName
    {
        void GetName(string x);
    }
    class User : IName
    {
        public void GetName(string a)
        {
            Console.WriteLine("Name:" + a);
        }
    }

    internal class InterfaceClassExample
    {

        private static void Main(string[] args)
        {
            User u = new User();
            u.GetName("Vishwa");

        }



    }

}
 

    





    

