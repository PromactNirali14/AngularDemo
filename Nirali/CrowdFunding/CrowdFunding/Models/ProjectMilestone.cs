using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ProjectMilestone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [ForeignKey("ProjectInfo")]
        public int ProjectInfoId { get; set; }
        public virtual ProjectInfo ProjectInfo { get; set; }
        [Required]
        public string MileStoneTitle { get; set; }
        [Required]
        public string Description { get; set; }
        public string Challenges { get; set; }
        public DateTime CompletionDate { get; set; }

    }
}