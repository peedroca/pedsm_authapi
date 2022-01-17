using System.Collections.Generic;
using authapi.Data.Entities;

namespace authapi.Data.Repositories
{
    public class UserLogRepository : IUserLogRepository
    {
        private readonly PedSMUserContext _context;

        public UserLogRepository(PedSMUserContext context)
        {
            _context = context;
        }

        public void Log(UserLog log)
        {
            _context.Add(log);
            _context.SaveChanges();
        }
    }
}