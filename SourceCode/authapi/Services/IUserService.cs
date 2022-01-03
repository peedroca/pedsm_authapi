using System.Collections.Generic;
using authapi.Models;

namespace authapi.Services
{
    public interface IUserService
    {
        LoginResponse SignIn(UserLogin login);
        UserRecoverResponse Recover(string username);
        void SignUp(UserSignUp user);
        void ChangePassword(UserRecover user);
        UserList Get(long id);
        IEnumerable<UserListReduced> List();
    }
}