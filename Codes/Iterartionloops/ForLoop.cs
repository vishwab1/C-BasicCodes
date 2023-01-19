using System;
using System.Text;
using System.Threading.Tasks;


    internal class ForLoop
    {
        private static void Main(string[] args)
        {


        for (int i = 1; i <= 4; i++)
        {
            if (i == 3)
                break;
            Console.WriteLine("i value: {0}", i);
        }

        //nested loop
        for (int i = 1; i <= 4; i++)
        {
            for (int j = i; j < 3; j++)
            {
                Console.WriteLine("i value: {0}, j value: {1}", i, j);
            }
        }



    }




}
    

