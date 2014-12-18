using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class SurveyQuestion
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Question { get; set; }
        public int Status { get; set; }

       
    }
}