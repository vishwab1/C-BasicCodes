using Microsoft.AspNetCore.Mvc;
using MyWebMVCApplication.Data;
using MyWebMVCApplication.Models;

namespace MyWebMVCApplication.Controllers
{
    public class UserController : Controller
    {

        private readonly MVCDemoDbContext dbCOntext;
        public UserController(MVCDemoDbContext dbCOntext)
        {
            this.dbCOntext = dbCOntext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addrequest)
        {
            Console.WriteLine(addrequest.Name);
            var user = new User()
            {

                Name = addrequest.Name,
            };
            dbCOntext.Add(user);
            dbCOntext.SaveChanges();

            return RedirectToAction("Show");
        }

        [HttpGet]
        public IActionResult Show()
        {
            var UserDetails=dbCOntext.Users.ToList();

        return View(UserDetails);
        }

        [HttpGet]
        public IActionResult UpdateView(int id)
        {
            var UserDetails = dbCOntext.Users.FirstOrDefault(n => n.Id == id);

           if (UserDetails != null) 
            {
                var userd = new UpdateUserViewModel(){ Id = UserDetails.Id,Name = UserDetails.Name};
                return View(userd);

            }
           return RedirectToAction("UpdateView");

           
        }

        [HttpPost]
        public IActionResult UpdateEmployee(UpdateUserViewModel updatevalue)
        {
            Console.WriteLine(updatevalue.Id);
            var userupdate = dbCOntext.Users.Find(updatevalue.Id);

            
            if (userupdate != null)
            {
                userupdate.Id= updatevalue.Id;
                userupdate.Name= updatevalue.Name;
                dbCOntext.Update(userupdate);
                dbCOntext.SaveChanges();

            }
          


            return RedirectToAction("Show");
        }

    }
}
