using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmMudProductTranT
    {
        public string EventId { get; set; }
        public string WellId { get; set; }
        public string DailyId { get; set; }
        public string MudProductId { get; set; }
        public double? QuantityAdjusted { get; set; }
        public string MudProductTranId { get; set; }
        public double? QuantityReceived { get; set; }
        public double? QuantityReturned { get; set; }
        public double? QuantityOrdered { get; set; }
        public double? QuantityUsed { get; set; }
        public string Remarks { get; set; }
        public double? ProductDailyCost { get; set; }
        public double? ApplicationRate { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
