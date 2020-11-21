using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmWellboreIntegT
    {
        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string HoleSectGroupId { get; set; }
        public string WellboreIntegId { get; set; }
        public DateTime? DateTest { get; set; }
        public double? WeightLotEmw { get; set; }
        public string IsAbsorption { get; set; }
        public string IsFracture { get; set; }
        public double? LotPress { get; set; }
        public double? TotalBhPress { get; set; }
        public double? LotMd { get; set; }
        public double? LotTvd { get; set; }
        public string TestType { get; set; }
        public double? WeightLotAmw { get; set; }
        public double? PumpRate { get; set; }
        public double? OpenHoleLength { get; set; }
        public double? MdWater { get; set; }
        public string LotFormation { get; set; }
        public string LotLithology { get; set; }
        public double? LotAzimuth { get; set; }
        public double? LotInclination { get; set; }
        public string TestResult { get; set; }
        public string IsTestContinuous { get; set; }
        public double? FluidApiWaterLoss { get; set; }
        public double? StabilizationPressure { get; set; }
        public double? StabilizationTime { get; set; }
        public double? VolFluidReturned { get; set; }
        public double? VolFluidAbsorbed { get; set; }
        public double? ChargeLoss { get; set; }
        public double? PumpHeight { get; set; }
        public string InjectionPoint { get; set; }
        public string Remarks { get; set; }
        public double? TotalVolume { get; set; }
        public string IsInjection { get; set; }

        public virtual CdHoleSectGroupT CdHoleSectGroupT { get; set; }
    }
}
