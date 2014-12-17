using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class SocialNetworkAccountInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }
        public string FacebookId { get; set; }
        public string TwitterId { get; set; }
        [StringLength(255)]
        public string GoogleId { get; set; }
        public string LinkedInId { get; set; }

    }
}