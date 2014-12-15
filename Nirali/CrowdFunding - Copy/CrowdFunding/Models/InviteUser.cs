using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class InviteUser
    {
        public int InviteUserTokenId { get; set; }
        [StringLength(256)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int UserInfoId { get; set; }
        [StringLength(40)]
        [Required]
        public string RegistrationToken { get; set; }
        public bool IsRegistered { get; set; }
        public DateTime InvitationSendTime { get; set; }
        public DateTime RegistrationTime { get; set; }

    }
}