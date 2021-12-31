using System;
using System.Collections.Generic;

#nullable disable

namespace authapi.Data.Entities
{
    public partial class UserNotice
    {
        public int IduserNotice { get; set; }
        public int UserId { get; set; }
        public bool CreatedUser { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Active { get; set; }
    }
}
