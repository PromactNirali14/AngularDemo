using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class NotificationLog
    {
        public int Id { get; set; }
        public int NotificationId { get; set; }
        public int ToUserId { get; set; }
        public int FromUserId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectUpdateId { get; set; }
        [StringLength(700)]
        public string ProjectUpdateTitle { get; set; }
        public int? ProjectCommentId { get; set; }
        [StringLength(500)]
        public string ProjectComment { get; set; }
        public int? ProjectUpdateCommentId { get; set; }
        [StringLength(500)]
        public string ProjectUpdateComment { get; set; }
        public DateTime DateTime { get; set; }
        public int? PledgedAmount { get; set; }
        [DataType(DataType.Currency)]
        public string CurrencySymbol { get; set; }
        public virtual Notification Notification{get;set;}

    }
}