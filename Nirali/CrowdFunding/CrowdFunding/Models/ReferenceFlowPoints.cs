using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdFunding.Models
{
    public class ReferenceFlowPoints
    {
        public int Id { get; set; }
        public int MeterFk { get; set; }
        public float FlowReynoldPoint { get; set; }
        public float PolynomValue { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}