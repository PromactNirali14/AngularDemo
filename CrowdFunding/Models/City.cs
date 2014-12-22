using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  System.ComponentModel.DataAnnotations;

namespace CrowdFunding.Models
{
    public class City
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string CityName { get; set; }
        public int StateId { get; set; }
    }
}