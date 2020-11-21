using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmMudVolumeT
    {
        public string WellId { get; set; }
        public string EventId { get; set; }
        public int? SequenceNo { get; set; }
        public string DailyId { get; set; }
        public string MudVolumeId { get; set; }
        public string MudVolDesc { get; set; }
        public string MudVolLocation { get; set; }
        public double? MudVol { get; set; }
        public double? MudFlowrate { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
