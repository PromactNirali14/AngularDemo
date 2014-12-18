using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ProjectStartRating
    {
        public int Id { get; set; }
        [ForeignKey("ProjectInfo")]
        public int ProjectInfoId { get; set; }
        public virtual ProjectInfo ProjectInfo { get; set; }
        [Range(18,2)]
        public decimal StarRate { get; set; }
        [ForeignKey("UserInfo")]
        public int? UserInfoId { get; set; }
        public virtual UserInfo userInfo { get; set; }

    }
}