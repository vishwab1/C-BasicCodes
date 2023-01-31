using System;
using System.IO;

using MySql.Data.MySqlClient;
class SqlExample
{

    static void Main(string[] args)
    {

        string sql = "server=localhost;userid=root;password=sql123;database=db_example";

        var con = new MySqlConnection(sql);
        con.Open();
        //con.ConnectionString= sql;

        //var stm = "SELECT * FROM books";
        //MySqlCommand mySqlCommand = new MySqlCommand(stm, con);
        //var stm= "INSERT INTO books(bookid,author,bookname,price) VALUES(@bookid,@author,@bookname,@price)";
        //var stm = " delete from books where bookid=@bookid";
        var stm = " update  books set author=@author,bookname=@bookname,price=@price where bookid=@bookid";

        MySqlCommand mySqlCommand = new MySqlCommand(stm, con);
        mySqlCommand.Parameters.AddWithValue("@bookid", 111);
        mySqlCommand.Parameters.AddWithValue("@author", "vishwa");
        mySqlCommand.Parameters.AddWithValue("@bookname", "java life");
        mySqlCommand.Parameters.AddWithValue("@price", 3666);
        mySqlCommand.Prepare();

        mySqlCommand.ExecuteNonQuery();

        //var version = mySqlCommand.ExecuteScalar().ToString();
       /* MySqlDataReader readeer = mySqlCommand.ExecuteReader();

        while (readeer.Read())
        {
         Console.WriteLine("{0} {1}", readeer.GetInt32(0), readeer.GetString(1));
        }*/


    }


}
    
