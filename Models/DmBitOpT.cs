using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmBitOpT
    {
        public string EventId { get; set; }
        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string AssemblyId { get; set; }
        public string DailyId { get; set; }
        public string AssemblyCompId { get; set; }
        public string WellboreFormationId { get; set; }
        public string BhaRunId { get; set; }
        public string BitOpId { get; set; }
        public string ActivityCode { get; set; }
        public DateTime? DateOp { get; set; }
        public double? Density { get; set; }
        public double? Azimuth { get; set; }
        public double? Flowrate { get; set; }
        public double? HydraulicHp { get; set; }
        public double? KiloRev { get; set; }
        public double? NozzleVelocity { get; set; }
        public string FormationName { get; set; }
        public double? OpDuration { get; set; }
        public double? OpProgress { get; set; }
        public double? Inclination { get; set; }
        public double? PressureDropBit { get; set; }
        public double? PressureStandpipe { get; set; }
        public double? RpmAvg { get; set; }
        public double? RpmCurrent { get; set; }
        public double? RpmDownHole { get; set; }
        public double? RpmMax { get; set; }
        public double? RpmMin { get; set; }
        public double? MdOp { get; set; }
        public double? Rop { get; set; }
        public double? WobAvg { get; set; }
        public double? TorqueAvg { get; set; }
        public double? WobCurrent { get; set; }
        public double? TorqueCurrent { get; set; }
        public double? TorqueMax { get; set; }
        public double? WobMax { get; set; }
        public double? WobMin { get; set; }
        public double? TorqueMin { get; set; }
        public double? PressureOffBottom { get; set; }
        public double? CirculatingTime { get; set; }
        public double? ConnectionTime { get; set; }
        public double? MdBase { get; set; }
        public double? MdTop { get; set; }
        public double? Rpg { get; set; }
        public double? StandpipePressureMin { get; set; }
        public double? StandpipePressureMax { get; set; }
        public double? RpmRotatingMin { get; set; }
        public double? RpmRotatingMax { get; set; }
        public double? RpmRotatingAvg { get; set; }
        public double? RpmRotatingCurrent { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
