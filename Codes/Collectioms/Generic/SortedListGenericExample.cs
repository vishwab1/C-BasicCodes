using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;





internal class SortedListGenericExample
{


        private static void Main(string[] args)
        {
        SortedList<int, string> slst = new SortedList<int, string>();

        slst.Add(1, "vishwa");
        slst.Add(3, "ankita");
        slst.Add(2, "manish");


        foreach (KeyValuePair<int, string> item in slst)
        {
            Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
        }
        
        Console.WriteLine("after deletion");
        slst.Remove(3);
        foreach (KeyValuePair<int, string> item in slst)
        {
            Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
        }
    }




}

 

    





    

