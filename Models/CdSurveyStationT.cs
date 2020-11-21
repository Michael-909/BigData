using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdSurveyStationT
    {
        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string SurveyHeaderId { get; set; }
        public string SurveyId { get; set; }
        public string ProjectId { get; set; }
        public string ProjectTargetId { get; set; }
        public double? Azimuth { get; set; }
        public DateTime? SurveyDate { get; set; }
        public double? OffsetEast { get; set; }
        public double? OffsetNorth { get; set; }
        public double? Inclination { get; set; }
        public float? BuildRate { get; set; }
        public double? Md { get; set; }
        public double? Tvd { get; set; }
        public int? SequenceNo { get; set; }
        public float? DoglegSeverity { get; set; }
        public short? PlanMethod { get; set; }
        public float? ToolFaceAngle { get; set; }
        public short? StationType { get; set; }
        public float? TurnRate { get; set; }
        public double? GravAxialRaw { get; set; }
        public double? GravTran1Raw { get; set; }
        public double? GravTran2Raw { get; set; }
        public double? MagAxialRaw { get; set; }
        public double? MagTran1Raw { get; set; }
        public double? MagTran2Raw { get; set; }
        public double? VerticalSect { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Remarks { get; set; }

        public virtual CdSurveyHeaderT CdSurveyHeaderT { get; set; }
    }
}
