using System;
using System.Collections.Generic;

namespace Projcet.Models
{
    public partial class Account
    {
        public Account()
        {
            Users = new HashSet<User>();
        }

        public int AccountId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int AuthorId { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
