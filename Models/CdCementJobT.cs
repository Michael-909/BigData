using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdCementJobT
    {
        public CdCementJobT()
        {
            CdCementFluidT = new HashSet<CdCementFluidT>();
            CdCementStageT = new HashSet<CdCementStageT>();
        }

        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string CementJobId { get; set; }
        public string IsDrilledOut { get; set; }
        public string JobDesc { get; set; }
        public string PipeMovementDesc { get; set; }
        public short? NumSqueezes { get; set; }
        public double? CasingTestPress { get; set; }
        public double? RecipDragDown { get; set; }
        public string CementJobNote { get; set; }
        public double? PlugMdBase { get; set; }
        public double? CasingTestDuration { get; set; }
        public string IsPipePulledWet { get; set; }
        public double? RecipDragUp { get; set; }
        public double? CblPress { get; set; }
        public string AssemblyId { get; set; }
        public DateTime? RecipFinishTime { get; set; }
        public DateTime? SqueezeDate { get; set; }
        public string CblQuality { get; set; }
        public double? PlugMdTop { get; set; }
        public DateTime? JobEndDate { get; set; }
        public string CetQuality { get; set; }
        public string PlugType { get; set; }
        public double? SqueezeDepth { get; set; }
        public string EventId { get; set; }
        public DateTime? RecipStartTime { get; set; }
        public string SqueezeType { get; set; }
        public DateTime? DrilledOutDate { get; set; }
        public double? PipePullRate { get; set; }
        public double? RecipStrokeLength { get; set; }
        public string Contractor { get; set; }
        public string DetectionIndicator { get; set; }
        public DateTime? JobStartDate { get; set; }
        public double? RecipSpm { get; set; }
        public double? Woc { get; set; }
        public double? TimeBeforeLinerTest { get; set; }
        public double? RotatingTorqueAvg { get; set; }
        public string ReportJournalId { get; set; }
        public double? TimeBeforeLogging { get; set; }
        public double? RotatingTorqueInitial { get; set; }
        public double? TimeBeforeShoeTest { get; set; }
        public string ContractorForeman { get; set; }
        public double? RotatingTorqueMax { get; set; }
        public string JobType { get; set; }
        public string IsBhtLogRun { get; set; }
        public DateTime? ContractorArrivalDate { get; set; }
        public string IsCblRun { get; set; }
        public DateTime? RotatingFinishTime { get; set; }
        public string Phase { get; set; }
        public string IsCetRun { get; set; }
        public DateTime? RotatingStartTime { get; set; }
        public DateTime? DateReport { get; set; }
        public string IsCementFound { get; set; }
        public double? RotatingRpm { get; set; }
        public string IsCo2Used { get; set; }
        public string IsCementFoundLiner { get; set; }
        public string IsLinerNegTestTool { get; set; }
        public string DayNo { get; set; }
        public string IsN2Used { get; set; }
        public string IsLinerPosTestTool { get; set; }
        public double? SurfaceGroundTemp { get; set; }
        public string IsRemCementRequired { get; set; }
        public double? SurfaceAirTemp { get; set; }
        public string IsShoeTestToolUsed { get; set; }
        public string IsTocSufficient { get; set; }
        public double? SeabedTemp { get; set; }
        public string JobRating { get; set; }
        public double? SurfaceAnnulusTemp { get; set; }
        public double? LinerEmwNegTest { get; set; }
        public string IsZoneIsolated { get; set; }
        public double? LinerEmwPosTest { get; set; }
        public double? RatHoleLength { get; set; }
        public double? LinerOverlap { get; set; }
        public double? ShoeTestOpenHole { get; set; }
        public double? ShoeTestPress { get; set; }
        public double? TocMd { get; set; }
        public string TocLocateMethod { get; set; }
        public string WellboreOpeningId { get; set; }
        public double? BottomHoleTemperature { get; set; }
        public double? GeothermalGradient { get; set; }
        public string ScenarioId { get; set; }
        public double? FluidDensity { get; set; }
        public string LogInterpretation { get; set; }
        public string LogInterpreter { get; set; }
        public double? MdFloat { get; set; }
        public double? PackerMd { get; set; }
        public DateTime? PressTestDate { get; set; }
        public string TestComments { get; set; }
        public double? TestSectionMdBase { get; set; }
        public double? TestSectionMdTop { get; set; }
        public double? ShoetrackTopMd { get; set; }
        public DateTime? ShoetrackDrillDate { get; set; }
        public double? ShoetrackDrillMd { get; set; }
        public double? TvdFloat { get; set; }
        public double? PackerTvd { get; set; }
        public double? PlugTvdBase { get; set; }
        public double? PlugTvdTop { get; set; }
        public double? ShoetrackDrillTvd { get; set; }
        public double? ShoetrackTopTvd { get; set; }
        public double? SqueezeTvd { get; set; }
        public double? TestSectionTvdBase { get; set; }
        public double? TestSectionTvdTop { get; set; }
        public double? TocTvd { get; set; }
        public double? ShoetrackDrillDistance { get; set; }
        public string AssemblyWbId { get; set; }
        public string ActivityPhase { get; set; }

        public virtual CdWellboreT Well { get; set; }
        public virtual ICollection<CdCementFluidT> CdCementFluidT { get; set; }
        public virtual ICollection<CdCementStageT> CdCementStageT { get; set; }
    }
}
