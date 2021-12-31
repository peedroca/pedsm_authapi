using System.Collections.Generic;
using authapi.Data.Entities;

namespace authapi.Data.Repositories
{
    public interface IUserRepository
    {
        User SignIn(string username, string password);
        void SignUp(User user);
        void Recover(UserRecover userRecover);
        void ChangePassword(User user);
        User Get(long id);
        List<User> List();
    }
}