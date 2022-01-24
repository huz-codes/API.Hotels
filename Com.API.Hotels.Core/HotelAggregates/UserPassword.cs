using Com.API.Hotels.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.API.Hotels.Core.Aggregates
{
    public class UserPassword : BaseEntity
    {
        public Guid PasswordId { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Password { get; set; }
        public string PasswordFormatId { get; set; }
        public string PasswordSalt { get; set; }
    }
}
