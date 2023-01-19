using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class ArrayPgm
    {
        private static void Main(string[] args)
        {
        ArrayList arrlist = new ArrayList();
        arrlist.Add("Hello");
        arrlist.Add(10);
        arrlist.Add(30.8);
        arrlist.Add("vishwa");
        Console.WriteLine("ArrayList Count: " + arrlist.Count);
        Console.WriteLine("ArrayList Capacity: " + arrlist.Capacity);

        Console.WriteLine("ArrayList:");
        // for loop to access arraylist elements
        for (int i = 0; i < arrlist.Count; i++)
        {
            Console.WriteLine(arrlist[i]);
        }

   

        //  insert        
        arrlist.Insert(4, 50);
        arrlist.Remove(30.8);
        // Removing an element at index 0
        arrlist.RemoveAt(0);
        Console.WriteLine("ArrayListwithinsertanddelete:");
        //foreach loop
        foreach (var item in arrlist)
        {
            Console.WriteLine(item);
        }
    }
    }

