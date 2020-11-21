using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmEventT
    {
        public DmEventT()
        {
            DmBulkT = new HashSet<DmBulkT>();
            DmCompanyT = new HashSet<DmCompanyT>();
            DmCrCleanupT = new HashSet<DmCrCleanupT>();
            DmDailyT = new HashSet<DmDailyT>();
            DmMudProductT = new HashSet<DmMudProductT>();
            DmOperEquipFailT = new HashSet<DmOperEquipFailT>();
            DmPersonnelT = new HashSet<DmPersonnelT>();
        }

        public string WellId { get; set; }
        public string EventId { get; set; }
        public double? AmountLastCostEst { get; set; }
        public string Phase { get; set; }
        public double? CostAuthorized { get; set; }
        public string CurrencyCode { get; set; }
        public double? ExchangeRate { get; set; }
        public DateTime? DateAuthorized { get; set; }
        public DateTime? DateOpsEnd { get; set; }
        public DateTime? DateLastCostEst { get; set; }
        public DateTime? DateOffProd { get; set; }
        public DateTime? DateOnProd { get; set; }
        public DateTime? DateOpsStart { get; set; }
        public string EventReason { get; set; }
        public double? EstimatedDays { get; set; }
        public string EquipType { get; set; }
        public string EventCode { get; set; }
        public string EventNo { get; set; }
        public string EventObjective1 { get; set; }
        public string EventType { get; set; }
        public string EventObjective2 { get; set; }
        public string EventTeam { get; set; }
        public string IsFinalReport { get; set; }
        public string IsReadonly { get; set; }
        public string StatusEnd { get; set; }
        public string Remarks { get; set; }
        public short? ReportingStandard { get; set; }
        public DateTime? ReportingTime { get; set; }
        public DateTime? CreateDate { get; set; }
        public string WellheadConnection { get; set; }
        public double? TvdCurrent { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public double? TvdPlugback { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public string BudgetType { get; set; }
        public string PlannedWci { get; set; }
        public string ActualWci { get; set; }
        public string WellGeometry { get; set; }
        public string Wta1 { get; set; }
        public string Wta2 { get; set; }
        public string WellboreInterface { get; set; }
        public double? RigMoveDistance { get; set; }
        public double? InitialLoadVolumeOil { get; set; }
        public double? InitialLoadVolumeWater { get; set; }
        public double? InitialLoadVolumeOther { get; set; }
        public string JobTypeId { get; set; }
        public string CostType { get; set; }
        public string ServiceType { get; set; }
        public string PrimaryServiceProvider { get; set; }
        public double? LostGasVol { get; set; }
        public double? LostOilVol { get; set; }
        public string IsProjectReadonly { get; set; }
        public double? ContingencyPercent { get; set; }
        public string OperatedType { get; set; }
        public string OperatedTypeCode { get; set; }
        public double? PaSuCompletionDays { get; set; }
        public string EventOperator { get; set; }
        public string EventObjective3 { get; set; }

        public virtual CdWellSource Well { get; set; }
        public virtual ICollection<DmBulkT> DmBulkT { get; set; }
        public virtual ICollection<DmCompanyT> DmCompanyT { get; set; }
        public virtual ICollection<DmCrCleanupT> DmCrCleanupT { get; set; }
        public virtual ICollection<DmDailyT> DmDailyT { get; set; }
        public virtual ICollection<DmMudProductT> DmMudProductT { get; set; }
        public virtual ICollection<DmOperEquipFailT> DmOperEquipFailT { get; set; }
        public virtual ICollection<DmPersonnelT> DmPersonnelT { get; set; }
    }
}
