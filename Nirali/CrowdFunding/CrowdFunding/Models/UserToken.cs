using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class UserToken
    {
        public int Id { get; set; }
        public int UserInfoId { get; set; }
        [Required]
        public string Token { get; set; }
        public int TokenType { get; set; }
        public DateTime TimeStamp { get; set; }
        [StringLength(30)]
        public string Provider { get; set; }
        [StringLength(100)]
        public string ProviderUserId { get; set; }
        [StringLength(256)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(60)]
        public string UserName { get; set; }
        public string ExternalLoginData { get; set; }
        public string AccessToken { get; set; }

        
    }
}