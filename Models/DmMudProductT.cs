using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmMudProductT
    {
        public string EventId { get; set; }
        public string MudProductId { get; set; }
        public string WellId { get; set; }
        public string ProductName { get; set; }
        public double? UnitPrice { get; set; }
        public string CostClass { get; set; }
        public string UnitSize { get; set; }
        public double? UnitMeasure { get; set; }
        public string CostCode { get; set; }
        public string CostSubcode { get; set; }
        public DateTime? DateFirstUsed { get; set; }
        public int? SequenceNo { get; set; }
        public double? Microtox { get; set; }
        public string Vendor { get; set; }
        public string MudFunction { get; set; }

        public virtual DmEventT DmEventT { get; set; }
    }
}
