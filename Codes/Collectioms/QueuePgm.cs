using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class QueuePgm
    {
        private static void Main(string[] args)
        {
        Queue que = new Queue();
        que.Enqueue("Vishwa");
        que.Enqueue(20.5f);
        que.Enqueue(10);
        
        Console.WriteLine("Contains Element 0: {0}", que.Contains(10));

        Console.WriteLine("Queue Count "+que.Count);

        
        foreach (var item in que)
        {
            Console.WriteLine(item);
        }
        que.Dequeue();
        Console.WriteLine("----------After deletion -----------------");
        // Access Queue  after deletion Elements
        Console.WriteLine("Queue Count " + que.Count);
        while (que.Count > 0)
        {
            Console.WriteLine(que.Dequeue());
        }


    }




}
    

