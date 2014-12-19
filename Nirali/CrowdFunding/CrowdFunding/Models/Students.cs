using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Students
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CityId { get; set; }
        [Required]
        public string BranchId { get; set; }
    
    }
}