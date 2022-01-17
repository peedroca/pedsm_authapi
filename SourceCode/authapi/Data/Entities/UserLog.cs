using System;
using System.Collections.Generic;

#nullable disable

namespace authapi.Data.Entities
{
    public partial class UserLog
    {
        public int IduserLog { get; set; }
        public int UserId { get; set; }
        public int UserLogTypesId { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Active { get; set; }

        public virtual User User { get; set; }
        public virtual UserLogType UserLogTypes { get; set; }
    }
}
