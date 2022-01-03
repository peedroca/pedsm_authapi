using System;
using System.Collections.Generic;
using System.Linq;
using authapi.Data.Entities;
using authapi.Data.Repositories;
using authapi.Models;

namespace authapi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        private readonly IUserLogService _logService;

        public UserService(IUserRepository repo, IUserLogService logService)
        {
            _repo = repo;
            _logService = logService;
        }

        public void ChangePassword(Models.UserRecover userRecover)
        {
            var user = _repo.Get(userRecover.Username);
            var recover = user.UserRecovers.SingleOrDefault(s => s.Code == userRecover.Code);

            if (recover == null)
                throw new ArgumentException("Recover code not founded!");
            if (recover.Expired)
                throw new ArgumentException("Code has been expired!");
            if (recover.ExpireDate < DateTime.Now)
                throw new ArgumentException("Code has been expired!");

            user.Password = userRecover.NewPassword;
            user.UserRecovers
                .First(f => f.IduserRecover == recover.IduserRecover)
                .Expired = true;

            _repo.ChangePassword(user);
            _logService.Log(user.Iduser, Models.UserLogType.PasswordChanged);
        }

        public UserList Get(long id)
        {
            var logs = _repo.GetLogs(id);
            var user = logs.FirstOrDefault()?.User;
            
            var userList = new UserList() 
            {
                Id = user?.Iduser ?? 0,
                Email = user?.Email,
                Username = user?.Username,
                Blocked = user?.Blocked ?? false,
                LastLogin = user?.LastLoginDate                          
            };

            userList.WithLogs(logs.Select(s => new Models.UserLog()
            {
                Content = s?.UserLogTypes?.Name,
                Register = s?.RegisterDate ?? System.DateTime.Now
            }).ToArray());

            return userList;
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

        public UserRecoverResponse Recover(string username)
        {
            var user = _repo.Get(username);

            var recover = new Data.Entities.UserRecover()
            {
                Code = GetUniqueRecoverCode(),
                Expired = false,
                Active = true,
                UserId = user.Iduser,
                ExpireDate = System.DateTime.Now.AddMinutes(30),
                IduserRecover = 0,
                RegisterDate = System.DateTime.Now
            };

            _repo.Recover(recover);

            return new UserRecoverResponse()
            {
                Email = user.Email,
                ExpirationDate = recover.ExpireDate,
                GeneratedCode = recover.Code
            };
        }

        private string GetUniqueRecoverCode()
        {
            var guid = Guid.NewGuid().ToString();
            return guid.ToUpper().Replace("-", "").Substring(0, 6);
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