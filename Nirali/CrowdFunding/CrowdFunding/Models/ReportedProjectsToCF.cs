using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ReportedProjectsToCF
    {
        public int Id { get; set; }
        [ForeignKey("ProjectInfo")]
        public int ProjectId { get; set; }
        public virtual ICollection<ProjectInfo> ProjectInfo { get; set; }
        public int UserId { get; set; }
        public int SelectedReason { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        public bool? IsApprovedByAdmin { get; set; }


    }
}