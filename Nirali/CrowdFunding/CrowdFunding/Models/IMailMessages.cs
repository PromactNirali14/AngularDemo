using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class IMailMessages
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        [ForeignKey("UserInfo")]
        public int FromUserId { get; set; }
        public virtual UserInfo UserInfo { get; set; }
  
        public bool IsBlockedSentItem { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}