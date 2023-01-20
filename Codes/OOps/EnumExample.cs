using System;
using System.Net.Sockets;
using System.Text;




class StructExample
{
    enum Week
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    static void Main(string[] args)
    {

        int a = (int)Week.Sunday;
        Console.WriteLine(Week.Sunday);
        Console.WriteLine("Sunday: {0}", a);

        foreach (string w in Enum.GetNames(typeof(Week)))
        {
            Console.WriteLine(w);
        }



    }


}
    
