using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmActivityT
    {
        public string WellId { get; set; }
        public string EventId { get; set; }
        public string ActivityId { get; set; }
        public string DailyId { get; set; }
        public string ActivityClass { get; set; }
        public string WellboreId { get; set; }
        public string WellboreZoneId { get; set; }
        public string ActivityCode { get; set; }
        public string ActivityGroup { get; set; }
        public string ActivityPhase { get; set; }
        public string ActivitySubcode { get; set; }
        public string ActivitySubcode2 { get; set; }
        public string CostClass { get; set; }
        public string ActivityAltCode1 { get; set; }
        public string ActivityAltCode2 { get; set; }
        public string CostCode { get; set; }
        public string CostSubcode { get; set; }
        public string ActivityAltCode3 { get; set; }
        public double? ActivityDuration { get; set; }
        public string StepNo { get; set; }
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
        public double? MdFrom { get; set; }
        public double? MdTo { get; set; }
        public string BillingCode { get; set; }
        public string ActivityMemo { get; set; }
        public string FailureId { get; set; }
        public int? NptLevel { get; set; }
        public string CompletionId { get; set; }
        public string ServiceCompany { get; set; }
        public string ActivityClassDesc { get; set; }
        public string ActivityCodeDesc { get; set; }
        public string ActivitySubcodeDesc { get; set; }
        public string Comments { get; set; }
        public string LinkedReportJournalId { get; set; }
        public double? OffBottomTorque { get; set; }
        public double? OnBottomTorque { get; set; }
        public double? PickupWeight { get; set; }
        public double? SlackoffWeight { get; set; }
        public double? RotatingOffBottom { get; set; }
        public string CustomCode1 { get; set; }
        public string CustomCode2 { get; set; }
        public string CustomCode3 { get; set; }
        public string CustomCode4 { get; set; }
        public string CustomCode5 { get; set; }
        public string CustomCode6 { get; set; }
        public int? SequenceNo { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
