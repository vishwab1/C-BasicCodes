using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using SimpleCWeb.Models;
using SimpleCWeb.Services;
using System.Configuration;
using System.Text.Encodings.Web;

namespace SimpleCWeb.Controllers
{

    public class HelloController : Controller
    {
         private readonly UserServicecs _userServicecs;

        public HelloController(UserServicecs userServicecs)
        {
            _userServicecs = userServicecs;
        }
        
        //passing value to controller
        /*static IList<User> UserList = new List<User>{
                new User() { rollno = 1, name = "John" } ,
                new User() { rollno = 2, name = "Steve", } 
          
            };*/
        public IActionResult I(string name, int numTimes)
        {
            List<User> Users = new List<User>();
            //string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            //MySqlConnection mySqlConnection= new MySqlConnection(constr);   

            //passing value to controller
            //Console.WriteLine(mySqlConnection);
            /* if(true)
             {
                 return RedirectToAction("In.cs");
             }*/

            //User use=new User();
            //use.rollno = "123";
            //use.name = "vishwa";
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {numTimes}");
            //return View(use)

            //_userServicecs.GetAll()
            return View(_userServicecs.GetAll()); }






        }
}
                                                   