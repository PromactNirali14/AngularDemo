using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ProjectUpdatesComments
    {
        public int Id { get; set; }
        [ForeignKey("ProjectUpdates")]
        public int ProjectUpdatesId { get; set; }
        public int UserInfoId { get; set; }
        [Required]
        public string Comment { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public virtual ProjectUpdates ProjectUpdates { get; set; }
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}