using System;
using System.Text;
using System.Threading.Tasks;


    internal class MethodsPgm
    {

    private static void Main(string[] args)
    {
         string Userinfo(string name, int age)
        {
            string info = string.Format("Name: {0}, Age: {1}", name, age);
            return info;
        }

        string info= Userinfo("vishwa", 25);
        Console.WriteLine(info);
    }

 

    }





    

