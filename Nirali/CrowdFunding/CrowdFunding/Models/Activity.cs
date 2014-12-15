using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Activity
    {
    
        public int ActivityId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        
   
    }
}