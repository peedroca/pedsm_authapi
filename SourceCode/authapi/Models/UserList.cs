using System;
using System.Collections;
using System.Collections.Generic;

namespace authapi.Models
{
    public class UserList
    {
        private List<UserLog> _logs;

        public UserList()
        {
            _logs = new List<UserLog>();
        }

        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool Blocked { get; set; }
        public DateTime LastLogin { get; set; }
        public IReadOnlyCollection<UserLog> Logs { get { return _logs.AsReadOnly(); } }

        public UserList WithLogs(params UserLog[] log)
        {
            _logs.AddRange(log);
            return this;
        }
    }
}