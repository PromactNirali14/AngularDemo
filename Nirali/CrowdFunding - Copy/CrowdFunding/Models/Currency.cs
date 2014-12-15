using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        [StringLength(1)]
        [DataType(DataType.Currency)] //for currency format
        public string? CurrencySymbol { get; set; }
        [StringLength(20)]
        public string? CurrencyName { get; set; }
        public int MinimumFundingAmount { get; set; }
        public int MininumBakingAmount { get; set; }

    }
}