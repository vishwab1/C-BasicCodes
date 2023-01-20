using System;
using System.Text;

internal class Program
{

    static void Main(string[] args)
    {
        //multiline
        string msg = @"Hi Guest,
    Welcome to Navadhiti
    Dot Net Intersting";
        Console.WriteLine(msg);

        //Format
        string name = "Vishwa";
        string Company = "Navadhiti";
        string Employee = string.Format("Name: {0}, Company: {1}", name, Company);
        Console.WriteLine(Employee);

        //access charcter
        for (int i = 0; i < name.Length; i++)
        {
            Console.Write(name[i]);
            Console.Write("\n");
        }

        //split
        string msg1 = "vishwa,%manish,-Ankita";
        string[] strarr = msg1.Split(new char[] { ',', '-', '%' });
        for (int i = 0; i < strarr.Length; i++)
        {
            Console.WriteLine(strarr[i]);
        }
        //replace
        
        string nmsg = msg.Replace("Hi", "Welcome");
        Console.WriteLine(nmsg);


        //Concat
        Console.WriteLine("Message: {0}", string.Concat(msg1, msg));

        //Contains
        Console.WriteLine("Contains: {0}", msg1.Contains("v"));

        Console.WriteLine("Substring with Length: {0}", msg1.Substring(3, 10));

        Console.WriteLine("Compare: {0}", string.Compare(msg1, msg));

        Console.WriteLine("Remove with Length: {0}", msg1.Remove(3, 7));

        StringBuilder sb = new StringBuilder("Vishwa", 25);
        sb.Append(", Navadhiti");
        
        Console.WriteLine(sb);
        Console.WriteLine("capacity:{0}",sb.Capacity);
    }


}
    
