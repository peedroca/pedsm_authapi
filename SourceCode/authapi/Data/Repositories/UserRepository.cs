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

        public void Update(object user)
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
            _context.Add(userRecover);
            _context.SaveChanges();
        }

        public User SignIn(string username, string password)
        {
            return _context
                .Users
                .Where(w => w.Username == username && w.Password == password)
                .SingleOrDefault();
        }

        public void Save(object user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }
    }
}