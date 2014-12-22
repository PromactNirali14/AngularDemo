using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ProjectAccountDetails
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int AccountType { get; set; }
        public string BankName { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string IfscCode { get; set; }
        [DataType(DataType.EmailAddress)]
        public string PaypalEmailId { get; set; }
        public string WireExtraDetails { get; set; }

         public virtual ProjectInfo ProjectInfo { get; set; }


    }
}