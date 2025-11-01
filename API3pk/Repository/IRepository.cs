using API3pk.Models;

namespace API3pk.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserById();
        User SetUser(User user);
        bool DeleteUser(int id);
    }
}
