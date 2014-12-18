using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ProjectUpdates
    {
        public int Id { get; set; }
        [ForeignKey("ProjectInfo")]
        public int ProjectInfoId { get; set; }
        public virtual ProjectInfo ProjectInfo { get; set; }
        public int UserInfoId { get; set; }
        [Required]
        [StringLength(140)]
        public string UpdateTitle { get; set; }
        [Required]
        public string UpdateDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }

    }
}