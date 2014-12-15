using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ParentcategoryId { get; set; }
        public int status { get; set; }
        public string? CategoryImage { get; set; }
    }
}