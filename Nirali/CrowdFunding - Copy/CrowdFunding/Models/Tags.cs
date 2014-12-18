using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DefaultValue(value:0)]
        public int? UserInfoId { get; set; }
        [DefaultValue(value: 0)]
        [ForeignKey("MasterProjectInfo")]
        public int? ProjectId { get; set; }
        public virtual MasterProjectInfo MasterProjectInfo { get; set; }

    }
}