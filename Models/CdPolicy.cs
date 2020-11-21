using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdPolicy
    {
        public CdPolicy()
        {
            CdProjectSource = new HashSet<CdProjectSource>();
        }

        public string CustomerName { get; set; }
        public string PolicyId { get; set; }
        public string AttachmentJournalId { get; set; }
        public short? ErrorSurface { get; set; }
        public string CustomerDivision { get; set; }
        public string CustomerRepresentative { get; set; }
        public short? WalkType { get; set; }
        public string CustomerGroup { get; set; }
        public string CustomerAddress { get; set; }
        public short? ErrorModel { get; set; }
        public string CustomerTelephone { get; set; }
        public short? ScanMethod { get; set; }
        public short? WarningMethod { get; set; }
        public double? ErrorOutputLevel { get; set; }
        public short? SurveyCalc { get; set; }
        public short? VsOrigin { get; set; }
        public string IsReadonly { get; set; }
        public short? ReportingStandard { get; set; }
        public DateTime? ReportingTime { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public double? ErrorLevel { get; set; }
        public short? UseCasing { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public string Remarks { get; set; }
        public string IsDualCurrency { get; set; }
        public string IsContingencyCalc { get; set; }
        public string ContingencyInfo { get; set; }
        public string ContingencyCodes { get; set; }
        public string BaCode { get; set; }
        public double? NotifyMinimumSeparation { get; set; }
        public double? NotifyCone { get; set; }
        public double? NotifyProjectionLength { get; set; }
        public short? NotifyProjectionType { get; set; }
        public short? NotifyOffsetScope { get; set; }
        public string NotifyOffsetSidetrack { get; set; }
        public int? ChecksumValue { get; set; }
        public string TemplateId { get; set; }
        public string UseSurfaceAnticollisionRule { get; set; }

        public virtual ICollection<CdProjectSource> CdProjectSource { get; set; }
    }
}
