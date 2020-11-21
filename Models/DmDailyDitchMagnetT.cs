using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmDailyDitchMagnetT
    {
        public string WellId { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public string MagnetId { get; set; }
        public int? SequenceNo { get; set; }
        public string Comments { get; set; }
        public double? TotalPipeRevs { get; set; }
        public double? WeightRecovered { get; set; }
        public DateTime? DateTime { get; set; }
        public double? Md { get; set; }
        public int? TimesCollected { get; set; }
        public double? TotalWeightRecovered { get; set; }
        public double? PipeRevs { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
