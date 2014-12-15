using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class InternalMailSystem
    {

        public int InternalMailSystemId { get; set; }
        public int? UserInfofromId { get; set; }
        public int? UserInfoToId { get; set; }
        [StringLength(256)]
        public string? Subject { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool IsRead { get; set; }
        public Guid MessageGuid { get; set; }
        public bool BlockSentItem { get; set; }
        public bool IsViewed { get; set; }


    }
}