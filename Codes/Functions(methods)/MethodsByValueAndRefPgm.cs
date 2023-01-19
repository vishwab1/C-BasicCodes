using System;
using System.Text;
using System.Threading.Tasks;


internal class MethodsByValueAndRefPgm
{

    private static void Main(string[] args)
    {


        int x = 10;
        Console.WriteLine(" Before Calling the Method: {0}", x);
        method1(x);
        Console.WriteLine("  After Calling the Method: {0}", x);

        Console.WriteLine(" Before Calling the Method ref : {0}", x);
        method2(ref x);
        Console.WriteLine("  After Calling the Method ref : {0}", x);

    }
    public static void method1(int a)
    {
        a *= a;
        Console.WriteLine("Variable Value Inside the Method: {0}", a);
    }

    public static void method2(ref int a)
    {
        a *= a;
        Console.WriteLine("Variable Value Inside the Method: {0}", a);
    }
}


 

    





    

