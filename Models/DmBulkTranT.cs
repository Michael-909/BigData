using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmBulkTranT
    {
        public string WellId { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public string BulkTranId { get; set; }
        public string BulkId { get; set; }
        public double? QuantityAdjusted { get; set; }
        public double? QuantityReceived { get; set; }
        public double? QuantityOnHand { get; set; }
        public double? QuantityOrdered { get; set; }
        public double? QuantityReturned { get; set; }
        public double? QuantityUsed { get; set; }
        public string Remarks { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
