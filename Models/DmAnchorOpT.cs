using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmAnchorOpT
    {
        public string WellId { get; set; }
        public string RigId { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public double? Azimuth { get; set; }
        public DateTime? DateOp { get; set; }
        public string AnchorId { get; set; }
        public string AnchorOpId { get; set; }
        public double? Tension { get; set; }
        public int? SequenceNo { get; set; }
        public double? Preload { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? Northing { get; set; }
        public double? Easting { get; set; }
        public string IsCarryover { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
