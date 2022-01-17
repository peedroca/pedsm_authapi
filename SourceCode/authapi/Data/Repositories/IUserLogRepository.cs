using System.Collections.Generic;
using authapi.Data.Entities;

namespace authapi.Data.Repositories
{
    public interface IUserLogRepository
    {
        void Log(Data.Entities.UserLog log);
    }
}