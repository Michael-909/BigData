using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmCompanyDailyT
    {
        public string WellId { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public string CompanyDailyId { get; set; }
        public string CompanyId { get; set; }
        public int? NumPeople { get; set; }
        public double? TotalHours { get; set; }
        public string IsCarryover { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
