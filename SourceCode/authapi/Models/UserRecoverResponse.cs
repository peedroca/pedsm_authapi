using System;

namespace authapi.Models
{
    public class UserRecoverResponse
    {
        public string GeneratedCode { get; set; }
        public string Email { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}