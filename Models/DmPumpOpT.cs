using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmPumpOpT
    {
        public string WellId { get; set; }
        public string RigId { get; set; }
        public string EventId { get; set; }
        public DateTime? DateOp { get; set; }
        public string DailyId { get; set; }
        public double? Efficiency { get; set; }
        public double? SlowPumpEfficiency { get; set; }
        public double? LinerId { get; set; }
        public string OpCode { get; set; }
        public double? Press { get; set; }
        public string PumpId { get; set; }
        public string PumpOpId { get; set; }
        public double? Spm { get; set; }
        public double? MdOp { get; set; }
        public double? Flowrate { get; set; }
        public int? SequenceNo { get; set; }
        public double? SuperchargerRunHours { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
