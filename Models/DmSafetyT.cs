using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmSafetyT
    {
        public string EventId { get; set; }
        public string WellId { get; set; }
        public string DailyId { get; set; }
        public double? ConnGasConcAvg { get; set; }
        public string SafetyId { get; set; }
        public double? DrillGasConcAvg { get; set; }
        public string TermNames { get; set; }
        public string BopFtConnector { get; set; }
        public double? TripGasConcAvg { get; set; }
        public string BopFtPods { get; set; }
        public double? BopPressureAnnular { get; set; }
        public double? BopPressureRamsLower { get; set; }
        public double? BopPressureKillLine { get; set; }
        public double? H2sGasConcAvg { get; set; }
        public double? ConnGasConcMax { get; set; }
        public double? BopPressureChokeLine { get; set; }
        public double? BopPressureChokeMan { get; set; }
        public double? DrillGasConcMax { get; set; }
        public double? TripGasConcMax { get; set; }
        public double? BopPressureDiverter { get; set; }
        public double? BopPressureKellyHose { get; set; }
        public string IsNoncompReceived { get; set; }
        public string IsSheenSpill { get; set; }
        public double? BopPressureRamsUpper { get; set; }
        public double? BopPressureSpMan { get; set; }
        public int? Bunks { get; set; }
        public string Remarks { get; set; }
        public DateTime? DateReport { get; set; }
        public string Reporter { get; set; }
        public string IsCompanyInspected { get; set; }
        public string IsGovernmentInspected { get; set; }
        public string IsJobsiteCheck { get; set; }
        public string InspectionResult { get; set; }
        public string SafetyMomentTopic { get; set; }
        public int? JobSafetyAnalysis { get; set; }
        public string SafetyNote { get; set; }
        public double? JobsiteEvaluation { get; set; }
        public string SafetyKeyword { get; set; }
        public double? DaysSinceDrill { get; set; }
        public string LostConnIncidentType { get; set; }
        public double? LastCasingTestPressure { get; set; }
        public DateTime? DateBopDrill { get; set; }
        public string MinorInjuryType { get; set; }
        public string DrillType { get; set; }
        public DateTime? DatePitDrill { get; set; }
        public int? RidCards { get; set; }
        public DateTime? DateBopFunction { get; set; }
        public DateTime? DateDiverterDrill { get; set; }
        public DateTime? DateBopTest { get; set; }
        public DateTime? DateH2sDrill { get; set; }
        public int? Terminated { get; set; }
        public DateTime? DateFireDrill { get; set; }
        public double? TonMiles { get; set; }
        public int? SequenceNo { get; set; }
        public DateTime? DateComTest { get; set; }
        public DateTime? DateCustom1 { get; set; }
        public DateTime? DateCustom2 { get; set; }
        public DateTime? DateEvacuationDrill { get; set; }
        public DateTime? DateRigInspection { get; set; }
        public DateTime? DateSafetyMeeting { get; set; }
        public DateTime? DateSafetyInspection { get; set; }
        public DateTime? DateCsgPressTest { get; set; }
        public DateTime? DateTripDrill { get; set; }
        public DateTime? DateWeeklyRigCheck { get; set; }
        public DateTime? DateNextBopTest { get; set; }
        public double? DaysSinceLtiTot { get; set; }
        public double? DaysSinceLtiOper { get; set; }
        public double? H2sGasConcMax { get; set; }
        public double? TimeOnDrillCollar { get; set; }
        public double? DaysOnDrillCollar { get; set; }
        public double? TimeOnDrillPipe { get; set; }
        public double? DaysOnDrillPipe { get; set; }
        public double? TimeOnGenBha { get; set; }
        public double? DaysOnGenBha { get; set; }
        public double? TimeOnOtherBha { get; set; }
        public double? DaysOnOtherBha { get; set; }
        public DateTime? SpareDate1 { get; set; }
        public string OtherBhaDesc { get; set; }
        public string SpareDesc1 { get; set; }
        public DateTime? SpareDate2 { get; set; }
        public string SpareDesc2 { get; set; }
        public double? TimeOnHeavyWeight { get; set; }
        public double? DaysOnHeavyWeight { get; set; }
        public double? DaysOnEquip1 { get; set; }
        public string DescEquip1 { get; set; }
        public double? DaysOnEquip2 { get; set; }
        public string DescEquip2 { get; set; }
        public double? TimeOnEquip3 { get; set; }
        public double? DaysOnEquip3 { get; set; }
        public string DescEquip3 { get; set; }
        public double? TimeOnEquip1 { get; set; }
        public double? TimeOnEquip2 { get; set; }
        public double? TimeOnJars { get; set; }
        public double? DaysOnJars { get; set; }
        public double? TimeOnShockSub { get; set; }
        public double? DaysOnShockSub { get; set; }
        public double? TimeOnStab { get; set; }
        public double? DaysOnStab { get; set; }
        public int? NumPtw { get; set; }
        public double? FlaredGas { get; set; }
        public double? VentedGas { get; set; }
        public DateTime? DateRamsTested { get; set; }
        public DateTime? DateAnnularTested { get; set; }
        public string IsCableCut { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
