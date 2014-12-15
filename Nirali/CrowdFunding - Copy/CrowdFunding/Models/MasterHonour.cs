using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class MasterHonour
    {
        public int HonourId { get; set; }
        public int MasterProjectInfoId { get; set; }
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