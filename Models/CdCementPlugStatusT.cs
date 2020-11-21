using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdCementPlugStatusT
    {
        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string CementJobId { get; set; }
        public string CementStageId { get; set; }
        public string CementPlugStatusId { get; set; }
        public double? MdBase { get; set; }
        public double? MdTop { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public double? TvdBase { get; set; }
        public double? TvdTop { get; set; }

        public virtual CdCementStageT CdCementStageT { get; set; }
    }
}
