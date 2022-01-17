namespace authapi.Models
{
    public enum UserLogType
    {
        Created=1,
        GeneratedAuthToken,
        PasswordChanged,
        Blocked,
        Unblocked,
    }
}