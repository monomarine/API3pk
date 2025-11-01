using API3pk.Models;

namespace API3pk.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly APIdbContext _context;
        public UserRepository(APIdbContext context)
        {
            _context = context;
        }
        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            var result = _context.Users;
            return result;
        }

        public User SetUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
