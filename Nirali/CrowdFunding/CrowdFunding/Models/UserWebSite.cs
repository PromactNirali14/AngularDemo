using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class UserWebSite
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Url)]
        public string WebSiteURL { get; set; }
        [ForeignKey("UserInfo")]
        public int UserInfoId { get; set; }
        public virtual UserInfo UserInfo { get; set; }

    }
}