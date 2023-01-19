using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Users
{
    public string Name { get; set; }

    public Users(string name)
    {
        Name = name;
        
    }
    public void GetUserDetails()
    {
        Console.WriteLine("Name: {0}", Name);
    }
}
internal class ClassExample
{

    private static void Main(string[] args)
    {
        Users user = new Users("vishwa");
        user.GetUserDetails();

    }



}


 

    





    

