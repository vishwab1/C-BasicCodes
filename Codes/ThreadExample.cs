using System;
using System.IO;
using System.Threading;
class ThreadExample
{

    static void Main(string[] args)
    {


        Thread th = Thread.CurrentThread;
        th.Name = "MainThread";

        Console.WriteLine("This is {0}", th.Name);

        ThreadStart childref = new ThreadStart(CallToChildThread);
        Thread childThread = new Thread(childref);
        childThread.Start();
        //Thread.Sleep(2000);

        //now abort the child
        Console.WriteLine("In Main: Aborting the Child thread");

        childThread.Interrupt();

    }

    private static void CallToChildThread()
    {

        try
        {
            Console.WriteLine("Child thread starts");

            // do some work, like counting to 10
            for (int counter = 0; counter <= 10; counter++)
            {
                Thread.Sleep(500);
                Console.WriteLine(counter);
            }

            Console.WriteLine("Child Thread Completed");
        }
        catch (ThreadAbortException e)
        {
            Console.WriteLine("Thread Abort Exception");
        }
        finally
        {
            Console.WriteLine("Couldn't catch the Thread Exception");
        }
    }
}
    
