using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class MasterProjectInfo
    {
        public int ProjectId { get; set; }
        public int? CategoryId { get; set; }
        [StringLength(450)]
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public string? DetailDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public int FundingDuration { get; set; }
        public int FundingGoal { get; set; }
        public string? ProjectVideo { get; set; }
        [StringLength(100)]
        public string? ReferenceURL { get; set; }
        public string? WebSiteURL { get; set; }
        [StringLength(100)]
        public string? BlogURL { get; set; }
        public string? Tags { get; set; }
        public string? ProjectPicture { get; set; }
        public DateTime? LaunchDate { get; set; }
        public int Status { get; set; }
        public int UserInfoId { get; set; }
        public bool CommentFlag { get; set; }
        public int PercentageComplete { get; set; }
        public bool IsPublished { get; set; }
        public bool IsHundredPercentageFunded { get; set; }
        public DateTime LastEditedDate { get; set; }
        public int FundingType { get; set;}
        public string? CountryName { get; set; }
        public string? StateName { get; set; }
        public string? CityName { get; set; }
        public bool IsChangesApproved { get; set; }
        public int CurrencyId { get; set; }
        public DateTime? LastSubmittedDate { get; set; }
        public DateTime? LastEditedByAdmin { get; set; }
        public bool IsAnySavedChangesPendingToLaunch { get; set; }


        
        







    }
}