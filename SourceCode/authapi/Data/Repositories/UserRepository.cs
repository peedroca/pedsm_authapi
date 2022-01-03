using System.Collections.Generic;
using System.Linq;
using authapi.Data.Entities;
using Microsoft.EntityFrameworkCore;

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
            _context.Update(user);
            _context.SaveChanges();
        }

        public User Get(string username)
        {
            return _context.Users
                .Include(o => o.UserRecovers)
                .Where(w => w.Username == username)
                .SingleOrDefault();
        }

        public List<UserLog> GetLogs(long id)
        {
            return _context
                .UserLogs
                .Include(o => o.User)
                .Include(o => o.UserLogTypes)
                .Where(w => w.UserId == id)
                .ToList();
        }

        public List<User> List()
        {
            return _context.Users.ToList();
        }

        public void Recover(UserRecover userRecover)
        {
            _context.UserRecovers.Add(userRecover);
            _context.SaveChanges();
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