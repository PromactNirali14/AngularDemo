using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class IMailMessages
    {
        public int IMailMessagesId { get; set; }
        public string? Subject { get; set; }
        public char Message { get; set; }
        public int FromUserId { get; set; }
        public bool IsBlockedSentItem { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}