using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class NewsletterSubscribe
    {
        public int Id { get; set; }
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string EmailId { get; set; }

        public bool IsSubscribed { get; set; }
    }
}