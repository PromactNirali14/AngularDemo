using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class MasterProjectPartners
    {
        public int Id { get; set; }
        [ForeignKey("MasterProjectInfo")]
        public int MasterProjectInfoId { get; set; }
        public virtual ICollection<MasterProjectInfo> MasterProjectInfo { get; set; } 
        [ForeignKey("UserInfo")]
        public int? PartnersUserId { get; set; }
        public virtual ICollection<UserInfo> UserInfo { get; set; }
        [Required]
        public string PartnersEmailId { get; set; }
        [Required]
        public string PartnersRole { get; set; }
        public bool IsPartnerAdded { get; set; }
        public DateTime? TokenSendingTimeStamp { get; set; }
        public Guid? Token { get; set; }
        public int PartnerRequestStatus { get; set; }
    }
}