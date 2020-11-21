using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdCementFluidT
    {
        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string CementJobId { get; set; }
        public string CementFluidId { get; set; }
        public double? Density { get; set; }
        public string FluidName { get; set; }
        public string FluidType { get; set; }
        public double? Gels10Min { get; set; }
        public double? Gels10Sec { get; set; }
        public double? Gels30Min { get; set; }
        public string MudType { get; set; }
        public double? Pv { get; set; }
        public double? Viscosity { get; set; }
        public double? Yp { get; set; }
        public double? Deflection { get; set; }
        public double? DensityAtPress { get; set; }
        public string DensityMethod { get; set; }
        public string ExcessMeasType { get; set; }
        public double? ExcessSlurryPercent { get; set; }
        public double? ExcessSlurryVol { get; set; }
        public double? MixWaterRatio { get; set; }
        public double? Rpm { get; set; }
        public string SlurryClass { get; set; }
        public double? SlurryDensity { get; set; }
        public string SlurryDesc { get; set; }
        public string SlurryMixMethod { get; set; }
        public string SlurryPurpose { get; set; }
        public string SlurryType { get; set; }
        public double? SlurryYield { get; set; }
        public string SourceWater { get; set; }
        public double? SourceWaterTemp { get; set; }
        public double? TempDensity { get; set; }
        public double? TempRheology { get; set; }
        public double? VolCementUsed { get; set; }
        public double? VolOtherUsed { get; set; }
        public double? VolSlurry { get; set; }
        public double? VolSlurryInWell { get; set; }
        public double? VolWaterUsed { get; set; }
        public double? SacksCalculated { get; set; }
        public double? SacksUsed { get; set; }
        public double? SackSize { get; set; }
        public double? Cc30Min { get; set; }
        public double? SlurryBaseTvd { get; set; }
        public double? SlurryTopTvd { get; set; }
        public double? PressMeasDens { get; set; }
        public int? SequenceNo { get; set; }
        public double? GaugedAnnularVol { get; set; }

        public virtual CdCementJobT CdCementJobT { get; set; }
    }
}
