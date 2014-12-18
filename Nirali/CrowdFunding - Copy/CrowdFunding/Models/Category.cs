using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Category
    {
        
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
        
       [ForeignKey("Category")]
        public int? ParentcategoryId { get; set; }
       
        public int status { get; set; }
        
        public string CategoryImage { get; set; }
    }
}