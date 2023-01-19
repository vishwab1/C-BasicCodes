using System;



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
 

    





    

