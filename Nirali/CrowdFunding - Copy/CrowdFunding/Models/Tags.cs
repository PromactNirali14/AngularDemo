using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Tags
    {
        public int Id { get; set; }
        [Required]
        public string TagName { get; set; }
        public int Status { get; set; }
        public int? UserInfoId { get; set; }
        public int? ProjectId { get; set; }

    }
}