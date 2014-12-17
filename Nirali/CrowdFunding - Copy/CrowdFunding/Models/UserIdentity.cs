using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class UserIdentity
    {
        public int Id { get; set; }
        public int IdentityType { get; set; }
        [StringLength(11)]
        public string SSNNumber { get; set; }
        public int OtherIdentityType1 { get; set; }
        public string OtherIdentityType1Document { get; set; }
        public int OtherIdentityType2 { get; set; }
        public string OtherIdentityType2Document { get; set; }
        public int UserInfoId { get; set; }
        [StringLength(14)]
        public string UIDAINumber { get; set; }
        public int IdentityVerificationStatus { get; set; }
        public int OtherIdentityTypeForCompanyProfile1 { get; set; }
        public int OtherIdentityTypeForCompanyProfile2 { get; set; }
        public DateTime? LastEditedByAdmin { get; set; }


    }
}