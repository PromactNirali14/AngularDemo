using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [StringLength(255)]
        [Required]
        public string Thread { get; set; }
        [StringLength(50)]
        [Required]
        public string Level { get; set; }
        [StringLength(255)]
        [Required]
        public string Logger { get; set; }
        [StringLength(2000)]
        [Required]
        public string Message { get; set; }
        [StringLength(4000)]
        [Required]
        public string Exception { get; set; }

    }
}