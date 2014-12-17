using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class webpages_Roles
    {
        public int Id { get; set; }
        [Required]
        [StringLength(256)]
       
        
        public string RoleName { get; set; }

    }
}