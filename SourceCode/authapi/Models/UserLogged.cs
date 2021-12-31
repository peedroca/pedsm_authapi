using System;

namespace authapi.Models
{
    public class UserLogged
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime LoginDate { get; set; }
    }
}