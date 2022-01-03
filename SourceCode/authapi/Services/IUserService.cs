using System.Collections.Generic;
using authapi.Models;

namespace authapi.Services
{
    public interface IUserService
    {
        LoginResponse SignIn(string username, string password);
        UserRecoverResponse Recover(string username);
        void SignUp(UserSignUp user);
        void ChangePassword(UserRecover user);
        UserList Get(long id);
        IEnumerable<UserListReduced> List();
    }
}