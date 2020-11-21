using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmSupportVesselDailyT
    {
        public string EventId { get; set; }
        public string WellId { get; set; }
        public string DailyId { get; set; }
        public string IsCarryover { get; set; }
        public string SupportVesselId { get; set; }
        public string Remarks { get; set; }
        public string SupportVesselDailyId { get; set; }
        public short? NumberOfCraft { get; set; }
        public short? PassengersInbound { get; set; }
        public short? PassengersOutbound { get; set; }
        public int? SequenceNo { get; set; }
        public DateTime? DateArrival { get; set; }
        public DateTime? DateDeparture { get; set; }
        public string ArrivalRemarks { get; set; }
        public string DepartureRemarks { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
