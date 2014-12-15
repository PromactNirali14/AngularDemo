using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public int UserInfoId { get; set; }
        public int CategoryId { get; set; }
    }
}