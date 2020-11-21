using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmHydrocloneOpT
    {
        public string WellId { get; set; }
        public string RigId { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public DateTime? DateOp { get; set; }
        public double? DensityFeed { get; set; }
        public double? DensityOverflow { get; set; }
        public double? DensityUnderflow { get; set; }
        public double? MdOp { get; set; }
        public double? Duration { get; set; }
        public string HydrocloneId { get; set; }
        public string HydrocloneOpId { get; set; }
        public string InsertType { get; set; }
        public string DischargeLocation { get; set; }
        public double? PressOp { get; set; }
        public double? FlowrateFeed { get; set; }
        public double? FlowrateOverflow { get; set; }
        public double? FlowrateUnderflow { get; set; }
        public string FeedSource { get; set; }
        public int? SequenceNo { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
