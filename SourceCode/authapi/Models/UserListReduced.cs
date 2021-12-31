using System;

namespace authapi.Models
{
    public class UserListReduced
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool Blocked { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}