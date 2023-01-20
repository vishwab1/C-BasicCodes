using System;
using System.IO;








class FileSystem
{

    static void Main(string[] args)
    {

        string fpath = @"D:\file.txt";
        string writeText = "Hello World!";  // Create a text string
        File.WriteAllText(fpath, writeText);  // Create a file and write the content of writeText to it

        string readText = File.ReadAllText(fpath);  // Read the contents of the file
        Console.WriteLine(readText);


        //Using file stream
        if (File.Exists(fpath))
        {
            File.Delete(fpath);
        }
        FileInfo fi = new FileInfo(fpath);
        using (StreamWriter sw = fi.CreateText())
        {
            sw.WriteLine("Hi");
            sw.WriteLine("\r\nWelcome to Navadhiti");
            sw.WriteLine("\r\nFileInfo");


        }

        using (StreamReader sr = fi.OpenText())
        {
            string txt;
           
            while ((txt = sr.ReadLine()) != null)
            {
                Console.WriteLine(txt);
            }
        }


    }


}
    
