using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmAfe
    {
        public DmAfe()
        {
            DmAfeSupp = new HashSet<DmAfeSupp>();
        }

        public string AfeDesc { get; set; }
        public string AfeId { get; set; }
        public string ActivityClass { get; set; }
        public string Estimator { get; set; }
        public string ActivityCode { get; set; }
        public string AfeNo { get; set; }
        public double? ActualDays { get; set; }
        public string ActivityPhase { get; set; }
        public string ApprovedBy { get; set; }
        public string ActivitySubcode { get; set; }
        public string BudgetDesc { get; set; }
        public double? AuthorizedMd { get; set; }
        public double? AfeTotal { get; set; }
        public double? AuthorizedTvd { get; set; }
        public string CurrencyCode { get; set; }
        public double? CumulativeCost { get; set; }
        public double? CurrencyExchRate { get; set; }
        public DateTime? DateApproval { get; set; }
        public DateTime? DateReport { get; set; }
        public double? EstimatedDays { get; set; }
        public string Department { get; set; }
        public double? ContingencyPercent { get; set; }
        public string DepartmentCode { get; set; }
        public string ProjectName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string ProjectCode { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public string Remarks { get; set; }
        public string AltCurrencyCode { get; set; }

        public virtual ICollection<DmAfeSupp> DmAfeSupp { get; set; }
    }
}
