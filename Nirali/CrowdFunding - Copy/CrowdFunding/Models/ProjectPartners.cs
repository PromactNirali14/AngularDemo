using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ProjectPartners
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int ProjectInfoId { get; set; }
        public int? PartnersUserId { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string PartnersEmailId { get; set; }
        [Required]
        public string PartnersRole { get; set; }
        public DateTime CreatedDateTime { get; set; }


    }
}