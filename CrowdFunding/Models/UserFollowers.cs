using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class UserFollowers
    {
        public int Id { get; set; }
        public int UserInfoId { get; set; }
        public int FollowerUserInfoId { get; set; }

        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}