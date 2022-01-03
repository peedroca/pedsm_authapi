using System.Collections.Generic;
using authapi.Data.Entities;
using authapi.Data.Repositories;

namespace authapi.Services
{
    public class UserLogService : IUserLogService
    {
        private readonly IUserLogRepository _repo;

        public UserLogService(IUserLogRepository repo)
        {
            _repo = repo;
        }

        public void Log(int userId, Models.UserLogType type)
        {
            var entity = new Data.Entities.UserLog()
            {
                IduserLog = 0,
                Active = true,
                RegisterDate = System.DateTime.Now,
                UserId = userId,
                UserLogTypesId = type.GetHashCode()
            };

            _repo.Log(entity);
        }
    }
}