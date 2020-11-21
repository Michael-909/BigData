using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdPerforateT
    {
        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string PerfId { get; set; }
        public string EventId { get; set; }
        public string AssemblyId { get; set; }
        public string Comments { get; set; }
        public string PerfNote { get; set; }
        public double? ShotDensityAverage { get; set; }
        public string AssemblyName { get; set; }
        public string CentralizationMethod { get; set; }
        public string ReportJournalId { get; set; }
        public string BalanceCondition { get; set; }
        public string Contractor { get; set; }
        public DateTime? DateTimeFinalPressure { get; set; }
        public string ContractorSupervisor { get; set; }
        public DateTime? ContractorArrival { get; set; }
        public double? FinalSurfacePressure { get; set; }
        public double? FluidDensity { get; set; }
        public string ReportNo { get; set; }
        public DateTime? ContractorRigup { get; set; }
        public double? FluidHead { get; set; }
        public double? FluidLossAfterPills { get; set; }
        public string FluidType { get; set; }
        public double? FormationDepth { get; set; }
        public DateTime? JobStart { get; set; }
        public DateTime? JobEnd { get; set; }
        public double? HydrostaticPressure { get; set; }
        public string IntervalType { get; set; }
        public string HowGunsConveyed { get; set; }
        public double? NumIntervals { get; set; }
        public double? PerfLengthNet { get; set; }
        public string PerfMethod { get; set; }
        public double? FluidLossAfterPerf { get; set; }
        public double? PerfLengthGross { get; set; }
        public DateTime? DateTimeRefLog { get; set; }
        public double? PressureDifference { get; set; }
        public string RefLogDescription { get; set; }
        public string IsUnderbalanced { get; set; }
        public double? ReservoirPressureEst { get; set; }
        public string MethodPlacing { get; set; }
        public double? SurfacePressure { get; set; }
        public double? MdBottomShot { get; set; }
        public double? PerfDiameter { get; set; }
        public double? MdTopShot { get; set; }
        public double? Penetration { get; set; }
        public int? TotalShots { get; set; }
        public double? TvdFluidTop { get; set; }
        public double? TvdReservoir { get; set; }
        public double? PillsSpottedVolume { get; set; }
        public string RefLogId { get; set; }
        public string PillsSpottedType { get; set; }
        public DateTime? DateReport { get; set; }

        public virtual CdWellboreT Well { get; set; }
    }
}
