using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class SurveyAnswer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Answer { get; set; }
        [ForeignKey("UserInfo")]
        public int? UserInfoId { get; set; }
        public virtual UserInfo UserInfo { get; set;} 
        [ForeignKey("ProjectInfo")]
        public int ProjectInfoId { get; set; }
         public virtual ProjectInfo ProjectInfo { get; set; }
        [ForeignKey("SurveyQuestion")]
        public int SurveyQuestionId { get; set; }
        public virtual SurveyQuestion SurveyQuestion { get; set; }

    }
}