using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmRigDecklogT
    {
        public string WellId { get; set; }
        public double? AvgDraft { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public double? BowDraft { get; set; }
        public double? BowLegReaction { get; set; }
        public string RigDecklogId { get; set; }
        public double? HeelAngle { get; set; }
        public string HeelPortOrStar { get; set; }
        public string InspectionComments { get; set; }
        public double? LegLoad1 { get; set; }
        public double? LegLoad2 { get; set; }
        public double? LegLoad3 { get; set; }
        public double? LegLoad4 { get; set; }
        public double? LegPenetration1 { get; set; }
        public double? LegPenetration2 { get; set; }
        public double? MaxLoad { get; set; }
        public double? LegPenetration3 { get; set; }
        public double? LegPenetration4 { get; set; }
        public double? OtherLegReact { get; set; }
        public double? PortLegReact { get; set; }
        public string Remarks { get; set; }
        public double? RigHeading { get; set; }
        public double? RigOffset { get; set; }
        public double? StabilityMargin { get; set; }
        public double? StarLegReact { get; set; }
        public double? SternDraft { get; set; }
        public DateTime? DateOp { get; set; }
        public double? TotalDeckLoad { get; set; }
        public double? TotalLegLoad { get; set; }
        public double? TrimAngle { get; set; }
        public string TrimSternOrBow { get; set; }
        public string OpType { get; set; }
        public double? VariableLegLoad { get; set; }
        public double? VariableDeckLoad { get; set; }
        public double? VesselDisplacement { get; set; }
        public double? VesselHeave { get; set; }
        public double? VesselPitch { get; set; }
        public double? VesselRoll { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
