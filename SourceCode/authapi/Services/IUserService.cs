using System.Collections.Generic;
using authapi.Models;

namespace authapi.Services
{
    public interface IUserService
    {
        LoginResponse SignIn(string username, string password);
        void SignUp(UserSignUp user);
        void Recover(string username);
        void ChangePassword(string username, string password, string code);
        UserList Get(long id);
        IEnumerable<UserListReduced> List();
    }
}