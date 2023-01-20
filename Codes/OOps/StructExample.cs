using System;
using System.Net.Sockets;
using System.Text;

struct User
{
    public const string name = "Vishwa";
    public string location;
    public int age;
    public User(string a, int b)
    {
        location = a;
        age = b;
    }
}


class StructExample
{

    static void Main(string[] args)
    {


        User u = new User("Banaglore", 24);

        User u1;
        Console.WriteLine("Name: {0}, Location: {1}, Age: {2}", User.name, u.location, u.age);

        u1.location = "Mangalore";
        u1.age = 25;
        Console.WriteLine("Name: {0}, Location: {1}, Age: {2}", User.name, u1.location, u1.age);


    }


}
    
