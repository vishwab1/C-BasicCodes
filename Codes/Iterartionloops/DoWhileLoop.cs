using System;
using System.Text;
using System.Threading.Tasks;


    internal class DoWhileLoop
    {
        private static void Main(string[] args)
        {

        int i = 1;
        do
        {
            Console.WriteLine("i value: {0}", i);
            i++;
            if (i == 2)
                break;
        } while (i < 4);
        Console.WriteLine("-----Nested--------");

        do
        {
            Console.WriteLine("i value: {0}", i);
            i++;
            int j = 1;
            do
            {
                Console.WriteLine("j value: {0}", j);
                j++;
            } while (j < 2);
        } while (i < 3);


    }




}
    

