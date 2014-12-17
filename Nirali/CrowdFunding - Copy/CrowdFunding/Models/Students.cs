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
        public string City_id { get; set; }
        [Required]
        public string Branch_id { get; set; }
    }
}