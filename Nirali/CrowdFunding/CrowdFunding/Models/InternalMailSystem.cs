using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class InternalMailSystem
    {

        public int Id { get; set; } 
        [ForeignKey("UserInfo")]
        public int? UserInfofromId { get; set; }
        public int? UserInfoToId { get; set; }
        [StringLength(256)]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        public DateTime CreatedDateTime { get; set; }
        
        public bool IsRead { get; set; }
        public Guid MessageGuid { get; set; }
        
        public bool BlockSentItem { get; set; }
        public bool IsViewed { get; set; }


        public virtual UserInfo UserInfo { get; set; }



    }
}