using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class Honour
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HonourId { get; set; }
    }
}