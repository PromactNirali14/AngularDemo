using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ProjectComment
    {
        public int Id { get; set; }
        public int ProjectInfoId { get; set; }
        [Required]
        public string Comment { get; set; }
        public int? UserInfoId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public int? ParentCommentId { get; set; }
        public int Status { get; set; }
        public int ParentReplyCommentId { get; set; }
        public int ParentReplyUserId { get; set; }


    }
}