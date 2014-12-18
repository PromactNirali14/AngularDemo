using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ProjectsOfTheWeek
    {
        public int Id { get; set; }
        [ForeignKey("ProjectInfo")]
        public int ProjectId { get; set; }
        public virtual ProjectInfo ProjectInfo { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public DateTime ScheduleStartDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }

    }
}