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
        public int ID { get; set; }
        [Required]
        public string City_Name { get; set; }
        [Key]
        [ForeignKey("Students")]
        public int StudentId { get; set; }
        public virtual ICollection<Students> Students { get; set; }
       public virtual Students Students { get; set; }
    }
}