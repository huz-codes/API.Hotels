using Com.API.Hotels.SharedKernel;
using System;

namespace Com.API.Hotels.Core.Aggregates
{
    public class User : BaseEntity
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastActivityDate { get; set; }
    }
}
