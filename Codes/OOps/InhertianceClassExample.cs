using System;

    public class A
    {
        public string Name;
        public void GetName()
        {
            Console.WriteLine("Name:"+ Name);
        }
    }
    public class B : A
    {
        public string Location;
        public void GetLocation()
        {
            Console.WriteLine("Location:"+Location);
        }
    }

public class C : B
{
    public int Age;
    public void GetAge()
    {
        Console.WriteLine("Age:"+Age);
    }
}
internal class InhertianceClassExample
{

    private static void Main(string[] args)
    {
        C c = new C();
        c.Name = "vishwa";
        c.Location = "bangalore";
        c.Age = 25;
        c.GetName();
        c.GetLocation();
        c.GetAge();

    }



}


 

    





    

