using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;





internal class ListGenericExample
    {


        private static void Main(string[] args)
        {
        List<int> lst = new List<int>();
        List<string> lst2 = new List<string>();

        lst.Add(1);
        lst.Add(2);
        Console.WriteLine("List1 Capacity: " + lst.Capacity);

        lst2.Add("hello");
        Console.WriteLine("List1 Capacity: " + lst2.Capacity);

        foreach (var item in lst)
        {
            Console.WriteLine("item:"+item);
        }



    }




}

 

    





    

