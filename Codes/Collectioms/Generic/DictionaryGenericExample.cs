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
        Dictionary<int, string> dct = new Dictionary<int, string>();

        dct.Add(1, "vishwa");
        dct.Add(3, "ankita");
        dct.Add(2, "manish");


        foreach (KeyValuePair<int, string> item in dct)
        {
            Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
        }
        
        Console.WriteLine("after deletion");
        dct.Remove(3);
        foreach (KeyValuePair<int, string> item in dct)
        {
            Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
        }
    }




}

 

    





    

