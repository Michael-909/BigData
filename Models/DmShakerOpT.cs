using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmShakerOpT
    {
        public string WellId { get; set; }
        public string RigId { get; set; }
        public double? ShakerAngle { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public DateTime? DateOp { get; set; }
        public double? MdOp { get; set; }
        public double? Duration { get; set; }
        public string ShakerId { get; set; }
        public string ShakerOpId { get; set; }
        public double? MudCover { get; set; }
        public int? SequenceNo { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
