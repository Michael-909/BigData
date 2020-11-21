using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmRiserOpT
    {
        public string WellId { get; set; }
        public double? BallJointAngle { get; set; }
        public string EventId { get; set; }
        public string RigId { get; set; }
        public string DailyId { get; set; }
        public double? BopAngle { get; set; }
        public double? GuideBaseAngle { get; set; }
        public double? RiserAngle { get; set; }
        public DateTime? DateOp { get; set; }
        public double? BallJointDirection { get; set; }
        public double? BopDirection { get; set; }
        public double? RiserDirection { get; set; }
        public string RiserId { get; set; }
        public string RiserOpId { get; set; }
        public double? RiserTension { get; set; }
        public double? RiserVol { get; set; }
        public int? SequenceNo { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
