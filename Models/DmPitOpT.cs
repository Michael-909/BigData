using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmPitOpT
    {
        public string WellId { get; set; }
        public string PitContents { get; set; }
        public string RigId { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public DateTime? DateOp { get; set; }
        public double? MudDensity { get; set; }
        public string IsActive { get; set; }
        public string PitId { get; set; }
        public string PitOpId { get; set; }
        public double? Viscosity { get; set; }
        public double? FluidVol { get; set; }
        public int? SequenceNo { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
