using System.Collections.Generic;
using System.Linq;
using authapi.Data.Entities;

namespace authapi.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PedSMUserContext _context;

        public UserRepository(PedSMUserContext context)
        {
            _context = context;
        }

        public void ChangePassword(User user)
        {
            throw new System.NotImplementedException();
        }

        public User Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public List<User> List()
        {
            return _context.Users.ToList();
        }

        public void Recover(UserRecover userRecover)
        {
            throw new System.NotImplementedException();
        }

        public User SignIn(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public void SignUp(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}