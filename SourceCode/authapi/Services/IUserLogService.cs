namespace authapi.Services
{
    public interface IUserLogService
    {
        void Log(int userId, Models.UserLogType type);
    }
}