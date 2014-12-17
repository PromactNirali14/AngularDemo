using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class SocialNetworkinfo
    {
        public int Id { get; set; }
        [Required]
        public string ProviderName { get; set; }
        public string UserName { get; set; }
        public int UserInfoId { get; set; }
        public string AccessToken { get; set; }
    }
}