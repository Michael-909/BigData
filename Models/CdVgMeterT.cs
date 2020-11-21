using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdVgMeterT
    {
        public string WellId { get; set; }
        public double? Deflection { get; set; }
        public string WellboreId { get; set; }
        public string VgMeterId { get; set; }
        public string FluidId { get; set; }
        public double? Rpm { get; set; }
        public int? SequenceNo { get; set; }
        public double? Temperature { get; set; }

        public virtual CdFluidT CdFluidT { get; set; }
    }
}
