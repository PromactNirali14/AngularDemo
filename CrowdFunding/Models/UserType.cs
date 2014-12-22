using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class UserType
    {
        public int Id { get; set; }
        [StringLength(20)]
        [Required]
        public string Type { get; set; }

    }
}