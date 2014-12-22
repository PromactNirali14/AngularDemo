using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class SocialNetworkInfo
    {
        public int Id { get; set; }
        [Required]
        public string ProviderName { get; set; }
        public string UserName { get; set; }
        [ForeignKey("UserInfo")]
        public int UserInfoId { get; set; }
        public virtual ICollection<UserInfo> UserInfo { get; set; }
        public string AccessToken { get; set; }
    }
}