using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Cities
    {
        public int ID { get; set; }
        [Required]
        public string City_Name { get; set; }
        public int StudentId { get; set; }
    }
}