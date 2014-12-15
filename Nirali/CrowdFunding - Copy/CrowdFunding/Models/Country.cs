using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Country
    {
         [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [StringLength(3)]
        [Required]
        public string CountryCode { get; set; }
        [StringLength(50)]
        [Required]
        public string CountryName { get; set; }

    }
}