using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(256)]
        public string Email { get; set;  }
        public DateTime CreatedDate { get; set; }
        public bool IsNewsLetter { get; set; }
        public bool IsProfileCreated { get; set; }
        public string AboutText { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        public int? Gender { get; set; }
        
        public string ProfilePic { get; set; }
        public bool IsAllowAllMail { get; set; }
        public int? CategoryId { get; set; }
       // [DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }
        public int? UserTypeId { get; set; }
        public int Status { get; set; }
        public string LoginType { get; set; }
        public string Interests { get; set; }
        public bool WhenSomeOneIfollowBacksOrLaunchesAProject { get; set; }
        public bool WhenIGetNewFollower { get; set; }
        public bool WhenCreatedProjectReceiveNewPledge { get; set; }
        public bool WhenCreatedProjectReceiveNewComments { get; set; }
        public bool WhenBakingProjectPostNewUpdates { get ; set;}
        public string ConfirmationToken { get; set; }
        public bool IsConnectedWithFaceBook { get; set; }
        public string FaceBookAccessToken { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set;  }
        public string Address { get; set; }
        [StringLength(15)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public bool IsLoginOnce { get; set; }
        [Required]
        [StringLength(30)]
        public string VanityURLName { get; set; }
        public bool IsVanityUrlChangeonce { get; set; }
                [StringLength(10)]
        
        public string ZipCode { get; set; }
        public DateTime LastViewedNotificationDateTime { get; set; }
        public string CompanyName { get; set; }
        public string ContactPersonName { get; set; }
        public DateTime? CompanyRegistrationDate { get; set; }
        public bool IsUserRegisteredWithCompanyProfile { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime? LastEditedByAdmin { get; set; }





    }
}