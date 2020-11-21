using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmBhaOpT
    {
        public string EventId { get; set; }
        public string WellId { get; set; }
        public string DailyId { get; set; }
        public string WellboreId { get; set; }
        public string BhaRunId { get; set; }
        public string BhaOpId { get; set; }
        public double? ActualHookLoad { get; set; }
        public DateTime? DateOp { get; set; }
        public double? Drag { get; set; }
        public double? DoglegSeverity { get; set; }
        public double? MaxOverpull { get; set; }
        public double? MdOp { get; set; }
        public double? StringWeightDown { get; set; }
        public string OperationType { get; set; }
        public double? StringWeightRotating { get; set; }
        public double? RotaryRpm { get; set; }
        public double? Rpm { get; set; }
        public double? StringWeightUp { get; set; }
        public double? TorqueOffBottom { get; set; }
        public double? TorqueOnBottom { get; set; }
        public double? WeightAboveJars { get; set; }
        public double? WeightBelowJars { get; set; }
        public double? TripRate { get; set; }
        public double? Tvd { get; set; }
        public double? ToolFaceOrientation { get; set; }
        public double? Inclination { get; set; }
        public double? Azimuth { get; set; }
        public double? FlowRate { get; set; }
        public double? StandPipePressure { get; set; }
        public double? DrillingHours { get; set; }
        public double? CirculatingHours { get; set; }
        public string DrillMode { get; set; }
        public double? Wob { get; set; }
        public double? OffBottomCircPressure { get; set; }
        public double? StandpipePressureMin { get; set; }
        public double? StandpipePressureMax { get; set; }
        public double? WobMin { get; set; }
        public double? WobMax { get; set; }
        public double? WobAvg { get; set; }
        public double? WobCurrent { get; set; }
        public double? RpmRotatingMin { get; set; }
        public double? RpmRotatingMax { get; set; }
        public double? RpmRotatingAvg { get; set; }
        public double? RpmRotatingCurrent { get; set; }
        public double? TorqueMin { get; set; }
        public double? TorqueMax { get; set; }
        public double? TorqueAvg { get; set; }
        public double? TorqueCurrent { get; set; }
        public double? TorqueOnBottomMin { get; set; }
        public double? TorqueOnBottomMax { get; set; }
        public double? TorqueOnBottomAvg { get; set; }
        public double? TorqueOnBottomCurrent { get; set; }
        public double? OnBottomCircPressure { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
