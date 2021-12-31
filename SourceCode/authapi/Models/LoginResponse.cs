namespace authapi.Models
{
    public class LoginResponse
    {
        public Token Token { get; set; }
        public UserLogged User { get; set; }
    }
}