using ApiAuth.Models;

namespace ApiAuth.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>()
            {
                new() { Id = 1, UserName = "Batman", Password = "Batman", Role = "manager"},
                new() { Id = 2, UserName = "Robin", Password = "Robin", Role = "employee"}
            };

            return users.FirstOrDefault(x => x.UserName == username && x.Password == password);
        }
    }
}
