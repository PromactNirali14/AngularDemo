using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ProjectFollowers
    {
        public int Id { get; set; }
        public int ProjectInfoId { get; set; }
        public int UserInfoId { get; set; }

    }
}