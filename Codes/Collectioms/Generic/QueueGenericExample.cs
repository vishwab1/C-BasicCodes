using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;





internal class QueueGenericExample
    {


        private static void Main(string[] args)
        {
        Queue<int> queue = new Queue<int>();
        

        queue.Enqueue(1);
        queue.Enqueue(2);
        



        foreach (var item in queue)
        {
            Console.WriteLine("item:"+item);
        }

        Console.WriteLine("after deletion");
        queue.Dequeue();
        foreach (var item in queue)
        {
            Console.WriteLine("item:" + item);
        }
    }




}

 

    





    

