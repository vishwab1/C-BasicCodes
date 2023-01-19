using System;
using System.Net.NetworkInformation;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


public class Calculate
{


    internal class ExceptioneClassExample
    {

        private static void Main(string[] args)
        {
            string name = null;
            try
            {
                if (name.Length > 0) // NULL
                {
                    Console.WriteLine("Name: " + name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:"+ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block.");
            }

        }



    }

}
 

    





    

