using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmPersonnelDailyT
    {
        public string WellId { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public string PersonnelDetailId { get; set; }
        public string PersonnelId { get; set; }
        public string IsInjured { get; set; }
        public string IsCarryover { get; set; }
        public string IsMeal1Required { get; set; }
        public string IsMeal2Required { get; set; }
        public string IsMeal3Required { get; set; }
        public string IsMeal4Required { get; set; }
        public double? HoursRegular { get; set; }
        public double? HoursOvertime { get; set; }
        public double? HoursTraining { get; set; }
        public double? HoursTrainingOvertime { get; set; }
        public string CompanyId { get; set; }
        public double? TotalHours { get; set; }
        public string Service { get; set; }
        public int? SequenceNo { get; set; }
        public DateTime? CrDate { get; set; }
        public string CrOperation { get; set; }
        public string CrContractor { get; set; }
        public string CrRating { get; set; }
        public string CrContactName { get; set; }
        public string CrContactPhone { get; set; }
        public string CrContactEmail { get; set; }
        public string CrComments { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
