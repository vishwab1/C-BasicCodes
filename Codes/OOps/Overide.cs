using System;
using System.Net.Sockets;
using System.Text;


class Base
{
    public virtual string Name { get; set; }
    public virtual void GetInfo()
    {
        Console.WriteLine("Learn C# Tutorial");
    }
}

class Derived:Base
{
    private string name;
    public override string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
            else
            {
                name = "No Value";
            }
        }
    }
    public override void GetInfo()
    {
        Console.WriteLine("Welcome to Tutlane");
    }
}
    

    

class Overide
{

    static void Main(string[] args)
    {

        Derived d = new Derived();
        d.GetInfo();
        Base b = new Base();
        b.GetInfo();
        d.Name = string.Empty;
        Console.WriteLine(d.Name);


    }


}
    
