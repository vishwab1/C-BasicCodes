using System;
using System.Text;
using System.Threading.Tasks;


    internal class WhileLoop
    {
        private static void Main(string[] args)
        {

        int i = 1;
        while (i < 4)
        {
            Console.WriteLine("i value: {0}", i);
            i++;
            if (i == 2)
                break;
        }
        Console.WriteLine("-----Nested--------");

        while (i < 4)
        {
            Console.WriteLine("i value: {0}", i);
            i++;
            int j = 1;
            while (j < 2)
            {
                Console.WriteLine("j value: {0}", j);
                j++;
            }
        }


    }




}
    

