using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class SocialMediaPostingInfo
    {
        public int Id { get; set; }
        public int UserInfoId { get; set; }
        public bool IsFbPostAllowed { get; set; }
        public bool IsGooglePostAllowed { get; set; }
        public bool IsLinkedInPostAllowed { get; set; }
        [ForeignKey("ProjectInfo")]
        public int ProjectInfoId { get; set; }
        public bool IsUserIsBacker { get; set; }


        public virtual ICollection<ProjectInfo> ProjectInfo { get; set; }

    }
}