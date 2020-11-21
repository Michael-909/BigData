using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmReportJournal
    {
        public string ReportJournalId { get; set; }
        public string WellId { get; set; }
        public DateTime? DatePrinted { get; set; }
        public string WellboreId { get; set; }
        public string CompletionId { get; set; }
        public DateTime? DateLocked { get; set; }
        public string EventId { get; set; }
        public string AfeId { get; set; }
        public string RigId { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateReport { get; set; }
        public DateTime? DateTransmitted { get; set; }
        public string ReportNo { get; set; }
        public string Description { get; set; }
        public string EntityType { get; set; }
        public string EventCode { get; set; }
        public string IsAutoprintFlag { get; set; }
        public string IsReadonly { get; set; }
        public string IsMainframeFlag { get; set; }
        public string IsModifiedFlag { get; set; }
        public string IsSendFlag { get; set; }
        public string LockUserId { get; set; }
        public string ModifiedBy { get; set; }
        public string IsReportComplete { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ReportAlias { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public string IsValidated { get; set; }
        public string SectionStatus { get; set; }
        public string StatusFilename { get; set; }
        public string TransferStatus { get; set; }
        public string IsProjectReadonly { get; set; }
        public string EquipmentTypeUsed { get; set; }
        public string ActivityTypeId { get; set; }
        public string ActivityInstanceId { get; set; }
        public string PadId { get; set; }
        public string PadOpId { get; set; }
        public string ParentReportJournalId { get; set; }
        public int? ActivitySequenceNo { get; set; }
    }
}
