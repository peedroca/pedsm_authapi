using System;
using System.Collections.Generic;

#nullable disable

namespace authapi.Data.Entities
{
    public partial class User
    {
        public User()
        {
            UserLogs = new HashSet<UserLog>();
            UserNotices = new HashSet<UserNotice>();
            UserRecovers = new HashSet<UserRecover>();
        }

        public int Iduser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public bool Blocked { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<UserLog> UserLogs { get; set; }
        public virtual ICollection<UserNotice> UserNotices { get; set; }
        public virtual ICollection<UserRecover> UserRecovers { get; set; }
    }
}
