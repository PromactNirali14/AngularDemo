using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class IMailRecipients
    {
         public int IMailRecipientsId { get; set; }
        public int MessageId { get; set; }
        public int ToUserId { get; set; }
        public bool IsRead { get; set; }
        public bool IsViewed { get; set; }
        public bool IsDeleted { get; set; }
    
    
    }
}