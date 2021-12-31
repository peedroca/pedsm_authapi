using System;

namespace authapi.Models
{
    public class Token
    {
        public string Content { get; set; }
        public DateTime Generation { get; set; }
        public DateTime Expiration { get; set; }
    }
}