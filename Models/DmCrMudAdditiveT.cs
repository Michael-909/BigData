using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmCrMudAdditiveT
    {
        public string WellId { get; set; }
        public string EventId { get; set; }
        public string CleanupId { get; set; }
        public string AdditiveId { get; set; }
        public int? SequenceNo { get; set; }
        public string MudProduct { get; set; }
        public double? AmountUsed { get; set; }
        public string AmountUnits { get; set; }
        public string OriginWellId { get; set; }
        public string OriginEventId { get; set; }

        public virtual DmCrCleanupT DmCrCleanupT { get; set; }
    }
}
