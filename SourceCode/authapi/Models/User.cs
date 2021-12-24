using System;

namespace authapi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Register { get; set; }
        public bool Active { get; set; }
    }
}