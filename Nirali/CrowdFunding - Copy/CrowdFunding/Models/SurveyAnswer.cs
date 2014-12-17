using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int? UserInfoId { get; set; }
        public int ProjectInfoId { get; set; }
        public int SurveyQuestionId { get; set; }

    }
}