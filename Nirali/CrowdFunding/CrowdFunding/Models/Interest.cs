using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Interest
    {
        public int Id { get; set; }
        [ForeignKey("UserInfo")]
        public int UserInfoId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual ICollection<Category> Category { get; set; }
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}