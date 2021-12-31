using System.Collections.Generic;
using System.Linq;
using authapi.Data.Repositories;
using authapi.Models;

namespace authapi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public void ChangePassword(string username, string password, string code)
        {
            throw new System.NotImplementedException();
        }

        public UserList Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserListReduced> List()
        {
            var userEntities = _repo.List();
            var users = userEntities.Select(s => new UserListReduced()
            {
                Id = s.Iduser,
                Username = s.Username,
                Email = s.Email,
                Blocked = s.Blocked,
                LastLogin = s.LastLoginDate
            });

            return users;
        }

        public void Recover(string username)
        {
            throw new System.NotImplementedException();
        }

        public LoginResponse SignIn(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public void SignUp(UserSignUp user)
        {
            throw new System.NotImplementedException();
        }
    }
}