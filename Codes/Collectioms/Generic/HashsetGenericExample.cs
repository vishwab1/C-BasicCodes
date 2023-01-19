using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;





internal class  DictionaryGenericExample
{


        private static void Main(string[] args)
        {
        HashSet<int> hset = new HashSet<int>();
        hset.Add(1);
        hset.Add(2);
        hset.Add(2);
        hset.Add(3);


        foreach (int item in hset)
        {
         
            Console.WriteLine(item);
        }
        Console.WriteLine("after deletion");
        hset.Remove(1);
        foreach (int item in hset)
        {

            Console.WriteLine(item);
        }
    }




}

 

    





    

