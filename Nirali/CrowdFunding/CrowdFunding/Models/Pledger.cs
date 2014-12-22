using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Pledger
    {
        public int Id { get; set; }
        [ForeignKey("UserInfo")]
        public int? UserInfoId { get; set; }
        public int PledgedAmount { get; set; }
        public int CurrencyCodeId { get; set; }
        [Required]
        public string ShippingAddress { get; set; }
         [ForeignKey("Honour")]
        public int HonourId { get; set; }
        public int ProjectInfoId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        [Required]
        [StringLength(60)]
        public string PledgerName{ get ; set ; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        [StringLength(75)]
        public string City { get; set; }
        [Required]
        [StringLength(10)]
        public string ZipCode { get; set; }
        public bool IsPaymentDone { get; set; }
        public bool GoAnonymous { get; set; }

        public virtual ICollection<UserInfo> UserInfo { get; set; }
        public virtual Honour Honour { get; set; }  


    }
}