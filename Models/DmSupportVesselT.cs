using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmSupportVesselT
    {
        public string WellId { get; set; }
        public string VesselName { get; set; }
        public string SupportVesselId { get; set; }
        public string ArrivalRemarks { get; set; }
        public string VesselOwner { get; set; }
        public DateTime? DateArrival { get; set; }
        public string VesselIdNo { get; set; }
        public DateTime? DateDeparture { get; set; }
        public string Remarks { get; set; }
        public string DepartureRemarks { get; set; }
        public string VesselType { get; set; }

        public virtual CdWellSource Well { get; set; }
    }
}
