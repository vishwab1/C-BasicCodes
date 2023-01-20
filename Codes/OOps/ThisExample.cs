using System;
using System.Net.Sockets;
using System.Text;

class User
{
    private  string name;
    private string location;
    public static string  age;//static
    const string company = "Navadhiti";

    // Parameterized Constructor
    public User(string name, string location)
    {
        this.name = name;
        this.location = location;
    }

    public void Details()
    {
        Console.WriteLine("name:{0},Age:{1},Company{2}", name,age, company);

    }


}

static class Employee
{

     public static string name;//static

    // Parameterized Constructor


    public static void Details()
    {
        Console.WriteLine("name:{0}", name);
        
    }


}
internal class ThisExample
{

    static void Main(string[] args)
    {
        

        User user = new User("vishwa","bangalore");
        User.age = "25";
        Employee.name = "Raju";
        Employee.Details();
        user.Details();


    }


}
    
