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
        public int CountryId { get; set; }
        [StringLength(3)]
        public string CountryCode { get; set; }
        [StringLength(50)]
        public string CountryName { get; set; }

    }
}