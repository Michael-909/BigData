using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdCementFluidScheduleT
    {
        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string CementJobId { get; set; }
        public string CementStageId { get; set; }
        public string FluidScheduleId { get; set; }
        public string CementFluidId { get; set; }
        public DateTime? DateStart { get; set; }
        public double? CdrmFoamDensity { get; set; }
        public double? CgrmFoamDensityAvg { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? SequenceNo { get; set; }
        public string FoamGasType { get; set; }
        public double? FoamGasVolUsed { get; set; }
        public double? BulkCement { get; set; }
        public string IsFoamJob { get; set; }
        public string IsFoamCgrm { get; set; }
        public double? Length { get; set; }
        public string Operation { get; set; }
        public string PlacementMethod { get; set; }
        public double? Rate { get; set; }
        public double? Density { get; set; }
        public double? Quality { get; set; }
        public double? ShutdownTime { get; set; }
        public short? GasRateNumber { get; set; }
        public double? CdrmRatioFinal { get; set; }
        public double? CdrmRatioInitial { get; set; }
        public double? TopOfFluid { get; set; }
        public double? Volume { get; set; }
        public double? Strokes { get; set; }
        public double? CgrmGlRatio { get; set; }
        public double? StrokeRate { get; set; }
        public double? BhCircTemp { get; set; }
        public double? BhStaticTemp { get; set; }
        public DateTime? DateEndPumping { get; set; }
        public DateTime? DateStartDisplace { get; set; }
        public DateTime? DateStartMixing { get; set; }
        public DateTime? DateStartSlurry { get; set; }
        public double? DispPressureFinal { get; set; }
        public double? DispRateAvg { get; set; }
        public double? RateFinal { get; set; }
        public double? RateMax { get; set; }
        public double? FlowlineTemp { get; set; }
        public double? MixingRate { get; set; }
        public double? OverflushVol { get; set; }
        public double? PreflushVol { get; set; }
        public double? MdBase { get; set; }
        public double? MdTop { get; set; }
        public double? SurfaceMixTemp { get; set; }
        public double? VolBackWash { get; set; }
        public double? TopOfFluidTvd { get; set; }

        public virtual CdCementStageT CdCementStageT { get; set; }
    }
}
