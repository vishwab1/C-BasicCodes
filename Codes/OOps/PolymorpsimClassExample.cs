using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;


public class Calculate
{
    public void AddNumbers(int a, int b)
    {
        Console.WriteLine("a + b = {0}", a + b);
    }
    public void AddNumbers(int a, int b, int c)
    {
        Console.WriteLine("a + b + c = {0}", a + b + c);
    }
}
//runtime 
public class BClass
{
    public virtual void GetInfo()
    {
        Console.WriteLine("This is base class");
    }
}
// Derived Class
public class DClass : BClass
{
    public override void GetInfo()
    {
        Console.WriteLine("This is Derive Class");
    }
}
internal class PolymorpsimClassExample
{

    private static void Main(string[] args)
    {
        Calculate c = new Calculate();
        c.AddNumbers(1, 2);
        c.AddNumbers(1, 2, 3);

        //Runtime
        DClass d = new DClass();
        d.GetInfo();
        BClass b = new BClass();
        b.GetInfo();

    }



}


 

    





    

