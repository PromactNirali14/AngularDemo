using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class AppSetting
    {
        public int AppSettingId { get; set; }
        public string Key { get; set; }
        public string value { get; set; }
        public string Description { get; set; }
    }
}