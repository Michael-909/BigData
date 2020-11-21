using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmCompanyT
    {
        public string WellId { get; set; }
        public string EventId { get; set; }
        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTelNo { get; set; }
        public string ContactFaxNo { get; set; }
        public string ContactAddress { get; set; }
        public int? SequenceNo { get; set; }
        public DateTime? FirstUsedDate { get; set; }

        public virtual DmEventT DmEventT { get; set; }
    }
}
