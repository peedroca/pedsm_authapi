using System;
using System.Collections.Generic;

#nullable disable

namespace authapi.Data.Entities
{
    public partial class UserLogType
    {
        public UserLogType()
        {
            UserLogs = new HashSet<UserLog>();
        }

        public int IduserLogType { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<UserLog> UserLogs { get; set; }
    }
}
