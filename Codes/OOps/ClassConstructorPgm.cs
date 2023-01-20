using System;
using System.Text;

class User
{
    public string name, location;

    //Stactic
    static User()
   {
       Console.WriteLine("I am Static Constructor");
    }

    // Parameterized Constructor
    public User(string a, string b)
    {
        name = a;
        location = b;
    }
    // Copy Constructor
    public User(User user)
    {
        name = user.name;
        location = user.location;
    }

    ~User()
    {
        Console.WriteLine("An Instance of class destroyed");
    }
}
internal class ClassConstructorPgm
{

    static void Main(string[] args)
    {

 
        User user = new User("Vishwanath", "Bangalore");
        
        User user1 = new User(user);
        user1.name = "Manish";
        user1.location = "Raichur";
        Console.WriteLine(user.name + ", " + user.location);
        Console.WriteLine(user1.name + ", " + user1.location);
        


    }


}
    
