using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Cities
    {
        public int Id { get; set; }
        [Required]
        public string CityName { get; set; }
        
        [ForeignKey("Students")]
        public int StudentId { get; set; }
     
      public virtual Students Students { get; set; }
    }
}