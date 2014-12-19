using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class MasterHonour
    {
        public int Id { get; set; }
        [ForeignKey("MasterProjectInfo")]
        public int MasterProjectInfoId { get; set; }
        public virtual MasterProjectInfo MasterProjectInfo { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int NumberOfSlot { get; set; }
        public int Status { get; set; }
        public int ShippingDetailsType { get; set; }
        public string ShippingCountries { get; set; }
        public bool IsHonourOwned { get; set; }
        public int SlotType { get; set; }
        public bool IsDefaultHonour { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
        [Required]
        public string ShippingCost { get; set; }

    }
}