using Microsoft.AspNetCore.Mvc;
using SimpleCWeb.Models;
using System.Text.Encodings.Web;

namespace SimpleCWeb.Controllers
{
    public class HelloController : Controller
    {

        //passing value to controller
        public IActionResult I(string name, int numTimes)
        {  

            //passing value to controller
            Console.WriteLine(name);
           /* if(true)
            {
                return RedirectToAction("In.cs");
            }*/

            User use=new User();
            use.rollno = "123";
            use.name = "vishwa";
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {numTimes}");
            return View(); }






        }
}
                                                   