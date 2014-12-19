using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ProjectComment
    {
        public int Id { get; set; }
        [ForeignKey("ProjectInfo")]
        public int ProjectInfoId { get; set; }
        public virtual ProjectInfo ProjectInfo { get; set; }
        [Required]
        public string Comment { get; set; }
        [ForeignKey("UserInfo")]
        public int? UserInfoId { get; set; }
        public virtual ICollection<UserInfo> UserInfo { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        [ForeignKey("ProjectComment")]
        public int? ParentCommentId { get; set; }
        public virtual ProjectComment ProjectComments { get; set; }
        public int Status { get; set; }
        public int ParentReplyCommentId { get; set; }
        public int ParentReplyUserId { get; set; }


    }
}