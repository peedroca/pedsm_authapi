using System;

namespace authapi.Models
{
    public class UserRecover
    {
        public string Username { get; set; }
        public string Code { get; set; }
        public string NewPassword { get; set; }
    }
}