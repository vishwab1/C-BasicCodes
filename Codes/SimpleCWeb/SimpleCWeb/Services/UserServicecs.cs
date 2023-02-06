using SimpleCWeb.Models;

namespace SimpleCWeb.Services
{
    public class UserServicecs : IUserServicecs
    {
        private List<User> UserList = new List<User>();

        public List<User> GetAll()
        {
            
            UserList.Add(new User { rollno=1 ,name="vishwa"});
            UserList.Add(new User { rollno = 2, name = "manish" });
            return UserList; }
    }
}
