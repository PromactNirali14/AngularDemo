using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class MasterProjectMilestone
    {
        public int ProjectMilestoneId { get; set; }
        public int MasterProjectInfoId { get; set; }
        public string MileStoneTitle { get; set; }
        public string Description { get; set; }
        public string? Challenges { get; set; }
        public DateTime CompletionDate { get; set; }


    }
}