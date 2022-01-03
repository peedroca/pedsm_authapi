using System;
using System.Collections.Generic;

#nullable disable

namespace authapi.Data.Entities
{
    public partial class UserRecover
    {
        public int IduserRecover { get; set; }
        public int UserId { get; set; }
        public bool Expired { get; set; }
        public string Code { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Active { get; set; }

        public virtual User User { get; set; }
    }
}
