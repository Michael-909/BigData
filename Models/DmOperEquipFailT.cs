using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmOperEquipFailT
    {
        public string WellId { get; set; }
        public string FailureId { get; set; }
        public string EventId { get; set; }
        public string WellboreId { get; set; }
        public string Cause { get; set; }
        public string LessonId { get; set; }
        public string ReportJournalId { get; set; }
        public double? FailureDayCost { get; set; }
        public double? FailureTotalCost { get; set; }
        public DateTime? CloseFailureDate { get; set; }
        public DateTime? DateFailureEnd { get; set; }
        public string EquipMetallurgy { get; set; }
        public DateTime? DateFailureStart { get; set; }
        public string EquipService { get; set; }
        public string FailureDescription { get; set; }
        public double? FailureDuration { get; set; }
        public string IsFailureClosed { get; set; }
        public DateTime? LastInspectionDate { get; set; }
        public double? FailureDepth { get; set; }
        public string EquipmentManufacturer { get; set; }
        public double? FailureOtherCost { get; set; }
        public string FailureLocation { get; set; }
        public string EquipmentOwner { get; set; }
        public string SerialNo { get; set; }
        public double? SystemAge { get; set; }
        public string FailureType { get; set; }
        public string SystemModel { get; set; }
        public string SystemSize { get; set; }
        public string SystemVendor { get; set; }
        public int? SequenceNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public string FailureTitle { get; set; }
        public string ContractorName { get; set; }
        public string EquipmentGroup { get; set; }
        public string EquipmentType { get; set; }
        public string EquipmentFailureCode { get; set; }
        public string Model { get; set; }
        public double? EquipmentCost { get; set; }
        public string ContactName { get; set; }
        public string Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public string ReviewerName { get; set; }
        public string RootCauseType { get; set; }
        public string RootCauseSummary { get; set; }
        public string Remarks { get; set; }
        public string NptDurationType { get; set; }
        public string NptEventAssessment { get; set; }
        public int? NptLevel { get; set; }
        public string NptOperationType { get; set; }
        public string NptResponseMatrix { get; set; }
        public string NptTeam { get; set; }
        public double? NptContractorCost { get; set; }
        public string NptPreventActions { get; set; }
        public string NptLearnings { get; set; }
        public string NptCoach { get; set; }
        public double? NptProductiveTimeAdjustment { get; set; }
        public double? NptNetTime { get; set; }
        public string NptCauseCode { get; set; }
        public string NptDescCode { get; set; }
        public string EquipFailType { get; set; }
        public string FirstActivityDailyId { get; set; }
        public string FirstActivityId { get; set; }
        public string LastActivityDailyId { get; set; }
        public string LastActivityId { get; set; }
        public DateTime? NptTargetCompletionDate { get; set; }
        public double? NptTotalCostNet { get; set; }
        public string PartNo { get; set; }
        public string InspectionType { get; set; }
        public double? HoursBeforeFail { get; set; }
        public string IsPrototypeEquip { get; set; }
        public string ContractorComment { get; set; }
        public string ContractorFindings { get; set; }
        public string NptNonConfNumber { get; set; }
        public double? NptNestedTime { get; set; }
        public string WellboreFormationId { get; set; }
        public double? NptPotentialProbability { get; set; }
        public string IsReadonly { get; set; }
        public string GlobalVendor { get; set; }

        public virtual DmEventT DmEventT { get; set; }
    }
}
