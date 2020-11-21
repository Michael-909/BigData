using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmCentrifugeOpT
    {
        public string WellId { get; set; }
        public string RigId { get; set; }
        public string CentrifugeId { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public DateTime? DateOp { get; set; }
        public double? DensityFeed { get; set; }
        public double? DensityOut { get; set; }
        public string CentrifugeOpId { get; set; }
        public double? DensityOverflow { get; set; }
        public double? DensityUnderflow { get; set; }
        public double? MdOp { get; set; }
        public double? Duration { get; set; }
        public string DischargeLocation { get; set; }
        public string FeedSource { get; set; }
        public string OpCode { get; set; }
        public double? OverflowFlowrate { get; set; }
        public double? FeedFlowrate { get; set; }
        public double? UnderflowFlowrate { get; set; }
        public double? Rpm { get; set; }
        public double? VolOilRetained { get; set; }
        public int? SequenceNo { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
