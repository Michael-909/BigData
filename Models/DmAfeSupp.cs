using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmAfeSupp
    {
        public string AfeId { get; set; }
        public string AfeSuppId { get; set; }
        public string AfeSuppNo { get; set; }
        public string ApprovedBy { get; set; }
        public double? CumSuppCost { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateSupplement { get; set; }
        public int? SequenceNo { get; set; }
        public string Remarks { get; set; }
        public string Pool { get; set; }

        public virtual DmAfe Afe { get; set; }
    }
}
