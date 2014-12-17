using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class MasterProjectPartners
    {
        public int Id { get; set; }
        public int MasterProjectInfoId { get; set; }
        public int? PartnersUserId { get; set; }
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