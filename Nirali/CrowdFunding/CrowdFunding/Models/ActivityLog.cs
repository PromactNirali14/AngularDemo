using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrowdFunding.Models
{
    public class ActivityLog
    {
        public int Id { get; set; }
        
        [ForeignKey("Activity")]
        public int ActivityId { get; set; }
        
        public int UserInfoId { get; set; }
        public int ProjectId { get; set; }
        public int? ParnerId { get; set; }
        public int? ProjectUpdateId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual Activity Activity { get; set; }
        
       
    }
}