using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmBulkT
    {
        public string WellId { get; set; }
        public string EventId { get; set; }
        public string BulkId { get; set; }
        public string ProductName { get; set; }
        public string UnitSize { get; set; }
        public double? UnitMeasure { get; set; }
        public DateTime? FirstUsedDate { get; set; }
        public int? SequenceNo { get; set; }

        public virtual DmEventT DmEventT { get; set; }
    }
}
