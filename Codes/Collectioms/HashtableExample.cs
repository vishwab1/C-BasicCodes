using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;





internal class HashtableExample
    {


        private static void Main(string[] args)
        {
        Hashtable htbl = new Hashtable();
        htbl.Add("name", "Vishwa");

        htbl.Add(1, 20.5);

        foreach (DictionaryEntry item in htbl)
        {
            Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
        }

        Console.WriteLine("Keys Retriwe");
        foreach (var item in htbl.Keys)
        {
            Console.WriteLine("Key = {0}", item);
        }

        Console.WriteLine("After Delete");
        htbl.Remove(1);
        foreach (DictionaryEntry item in htbl)
        {
            Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
        }

    }




}

 

    





    

