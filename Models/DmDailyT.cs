using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmDailyT
    {
        public DmDailyT()
        {
            DmActivityT = new HashSet<DmActivityT>();
            DmAnchorOpT = new HashSet<DmAnchorOpT>();
            DmBhaOpT = new HashSet<DmBhaOpT>();
            DmBitOpT = new HashSet<DmBitOpT>();
            DmBulkTranT = new HashSet<DmBulkTranT>();
            DmCentrifugeOpT = new HashSet<DmCentrifugeOpT>();
            DmCompanyDailyT = new HashSet<DmCompanyDailyT>();
            DmDailyDitchMagnetT = new HashSet<DmDailyDitchMagnetT>();
            DmDailyNotificationT = new HashSet<DmDailyNotificationT>();
            DmEnvironmentalT = new HashSet<DmEnvironmentalT>();
            DmHydrocloneOpT = new HashSet<DmHydrocloneOpT>();
            DmMudProductTranT = new HashSet<DmMudProductTranT>();
            DmMudVolumeT = new HashSet<DmMudVolumeT>();
            DmPersonnelDailyT = new HashSet<DmPersonnelDailyT>();
            DmPitOpT = new HashSet<DmPitOpT>();
            DmPumpOpT = new HashSet<DmPumpOpT>();
            DmRigDecklogT = new HashSet<DmRigDecklogT>();
            DmRiserOpT = new HashSet<DmRiserOpT>();
            DmSafetyT = new HashSet<DmSafetyT>();
            DmShakerOpT = new HashSet<DmShakerOpT>();
            DmSupportVesselDailyT = new HashSet<DmSupportVesselDailyT>();
            DmWeatherCheckT = new HashSet<DmWeatherCheckT>();
        }

        public string WellId { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public string CommentForecast24 { get; set; }
        public string WellboreId { get; set; }
        public string ReportJournalId { get; set; }
        public string CommentGeneral { get; set; }
        public string CommentOperational { get; set; }
        public string CommentSummary { get; set; }
        public string CommentWeather { get; set; }
        public string HoleCondition { get; set; }
        public double? DailyCost { get; set; }
        public double? DailyMudCost { get; set; }
        public double? MagneticDeclination { get; set; }
        public double? ExchangeRate { get; set; }
        public string FormationName { get; set; }
        public DateTime? DateReport { get; set; }
        public double? FormationTop { get; set; }
        public string ReportNo { get; set; }
        public double? DaysAhead { get; set; }
        public double? DaysFromSpud { get; set; }
        public double? DaysOnLocation { get; set; }
        public double? DaysOnTurnkey { get; set; }
        public double? RotatingElapsedTime { get; set; }
        public string IsDrillCapable { get; set; }
        public string IsFinalReport { get; set; }
        public string DrillingCompletionInd { get; set; }
        public int? LagStrokes { get; set; }
        public double? LagTime { get; set; }
        public double? LinerSize { get; set; }
        public string LithologyCurrent { get; set; }
        public string SupervisorName1 { get; set; }
        public double? LinerTop { get; set; }
        public string SupervisorName2 { get; set; }
        public string SupervisorName3 { get; set; }
        public string SupervisorName4 { get; set; }
        public double? PressureCasing { get; set; }
        public double? PressureMasic { get; set; }
        public double? PressureAmw { get; set; }
        public double? PackerDepth { get; set; }
        public string PackerType { get; set; }
        public double? PressureTubing { get; set; }
        public double? PlugbackMd { get; set; }
        public double? RigFuelConsumption { get; set; }
        public double? Progress { get; set; }
        public double? PlugbackTvd { get; set; }
        public double? RopAvgDay { get; set; }
        public double? RopCurrent { get; set; }
        public double? DailyTroubleCost { get; set; }
        public string Status { get; set; }
        public double? MdCurrent { get; set; }
        public double? VelAnnularCritical { get; set; }
        public double? TvdCurrent { get; set; }
        public double? VelAnnularDc1st { get; set; }
        public double? VelAnnularDc2nd { get; set; }
        public double? VelAnnularDp { get; set; }
        public double? VelAnnularDpCsg { get; set; }
        public double? VelCuttingsSlip { get; set; }
        public double? VelRiser { get; set; }
        public double? TubingDepth { get; set; }
        public double? WellheadRadiation { get; set; }
        public double? TubingSize { get; set; }
        public double? MudLossMdBase { get; set; }
        public double? MudLossMdTop { get; set; }
        public string DailyNote { get; set; }
        public string LithologyDescription { get; set; }
        public string Reviewer { get; set; }
        public string IsApproved { get; set; }
        public double? WirelineWorkUnitSize { get; set; }
        public double? FillDepth { get; set; }
        public double? InitialFlowRate { get; set; }
        public double? FinalFlowRate { get; set; }
        public double? OpenHoleFlowRate { get; set; }
        public double? InitialFlowPressure { get; set; }
        public double? FinalFlowPressure { get; set; }
        public double? OpenHoleFlowPressure { get; set; }
        public double? OrificeDiameter { get; set; }
        public DateTime? DateLastWirelineWork { get; set; }
        public DateTime? FillDate { get; set; }
        public string TreeCondition { get; set; }
        public string IsConventionalWell { get; set; }
        public double? MdFill { get; set; }
        public double? WuCtWlineDiameter { get; set; }
        public string GasProducedTo { get; set; }
        public string ActivityGroupFilter { get; set; }
        public string CrSuperPhone { get; set; }
        public double? CrPercentComplete { get; set; }
        public double? ContingencyPercent { get; set; }
        public double? PercentComplete { get; set; }
        public string SuperPhone { get; set; }
        public string IsCostApproved { get; set; }
        public string CostApprovedBy { get; set; }
        public double? FormationGradient { get; set; }
        public double? DailyCostCalc { get; set; }
        public string DirectionalCompany { get; set; }
        public string MwdCompany { get; set; }
        public string MudCompany { get; set; }
        public string SupervisorName5 { get; set; }
        public string SupervisorName6 { get; set; }
        public string SupervisorName7 { get; set; }
        public string SupervisorName8 { get; set; }
        public string SupervisorName9 { get; set; }
        public string SupervisorName0 { get; set; }

        public virtual DmEventT DmEventT { get; set; }
        public virtual ICollection<DmActivityT> DmActivityT { get; set; }
        public virtual ICollection<DmAnchorOpT> DmAnchorOpT { get; set; }
        public virtual ICollection<DmBhaOpT> DmBhaOpT { get; set; }
        public virtual ICollection<DmBitOpT> DmBitOpT { get; set; }
        public virtual ICollection<DmBulkTranT> DmBulkTranT { get; set; }
        public virtual ICollection<DmCentrifugeOpT> DmCentrifugeOpT { get; set; }
        public virtual ICollection<DmCompanyDailyT> DmCompanyDailyT { get; set; }
        public virtual ICollection<DmDailyDitchMagnetT> DmDailyDitchMagnetT { get; set; }
        public virtual ICollection<DmDailyNotificationT> DmDailyNotificationT { get; set; }
        public virtual ICollection<DmEnvironmentalT> DmEnvironmentalT { get; set; }
        public virtual ICollection<DmHydrocloneOpT> DmHydrocloneOpT { get; set; }
        public virtual ICollection<DmMudProductTranT> DmMudProductTranT { get; set; }
        public virtual ICollection<DmMudVolumeT> DmMudVolumeT { get; set; }
        public virtual ICollection<DmPersonnelDailyT> DmPersonnelDailyT { get; set; }
        public virtual ICollection<DmPitOpT> DmPitOpT { get; set; }
        public virtual ICollection<DmPumpOpT> DmPumpOpT { get; set; }
        public virtual ICollection<DmRigDecklogT> DmRigDecklogT { get; set; }
        public virtual ICollection<DmRiserOpT> DmRiserOpT { get; set; }
        public virtual ICollection<DmSafetyT> DmSafetyT { get; set; }
        public virtual ICollection<DmShakerOpT> DmShakerOpT { get; set; }
        public virtual ICollection<DmSupportVesselDailyT> DmSupportVesselDailyT { get; set; }
        public virtual ICollection<DmWeatherCheckT> DmWeatherCheckT { get; set; }
    }
}
