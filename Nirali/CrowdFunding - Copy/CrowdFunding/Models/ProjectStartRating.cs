using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ProjectStartRating
    {
        public int Id { get; set; }
        public int ProjectInfoId { get; set; }
        [Range(18,2)]
        public decimal StarRate { get; set; }
        public int? UserInfoId { get; set; }

    }
}