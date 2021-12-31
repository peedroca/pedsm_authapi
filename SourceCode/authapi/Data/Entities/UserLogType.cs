using System;
using System.Collections.Generic;

#nullable disable

namespace authapi.Data.Entities
{
    public partial class UserLogType
    {
        public int IduserLogType { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
