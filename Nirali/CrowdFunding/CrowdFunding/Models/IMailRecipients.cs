using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class IMailRecipients
    {
         public int Id { get; set; }
        [ForeignKey("IMailMessages")]
        public int MessageId { get; set; }
       
        [ForeignKey("UserInfo")]
        public int ToUserId { get; set; }
        
        public bool IsRead { get; set; }
        public bool IsViewed { get; set; }
        public bool IsDeleted { get; set; }


        public virtual ICollection<IMailMessages> IMailMessages { get; set; }
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    
    
    }
}