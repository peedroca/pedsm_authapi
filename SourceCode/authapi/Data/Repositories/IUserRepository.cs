using System.Collections.Generic;
using authapi.Data.Entities;

namespace authapi.Data.Repositories
{
    public interface IUserRepository
    {
        User SignIn(string username, string password);
        void Recover(UserRecover userRecover);
        List<UserLog> GetLogs(long id);
        User Get(string username);
        List<User> List();

        void Save(object user);
        void Update(object user);
    }
}