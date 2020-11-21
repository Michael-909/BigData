using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdSurveyHeaderT
    {
        public CdSurveyHeaderT()
        {
            CdSurveyStationT = new HashSet<CdSurveyStationT>();
        }

        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string TieWellboreId { get; set; }
        public string CaseId { get; set; }
        public string SurveyHeaderId { get; set; }
        public short? SurveyType { get; set; }
        public string Phase { get; set; }
        public string SurveyToolId { get; set; }
        public string PolicyId { get; set; }
        public string TieSurveyHeaderId { get; set; }
        public string Company { get; set; }
        public string Engineer { get; set; }
        public short? DefinitivePlan { get; set; }
        public DateTime? HeaderDate { get; set; }
        public string SurveyName { get; set; }
        public string Description { get; set; }
        public short? TieOnType { get; set; }
        public double? MdMin { get; set; }
        public double? MdMax { get; set; }
        public double? TieOnDepth { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string IsReadonly { get; set; }
        public string CreateAppId { get; set; }
        public string OverrideReason { get; set; }
        public short? ProcessingOption { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public short? VersionNo { get; set; }
        public string WellDesc { get; set; }
        public DateTime? DateEnd { get; set; }
        public double? AzimuthCorrection { get; set; }
        public string AzimuthReference { get; set; }
        public string IsInterferenceApplied { get; set; }
        public double? MagneticInterference { get; set; }
        public double? InterferenceCorrection { get; set; }
        public string IsSagApplied { get; set; }
        public double? InclinationCorrection { get; set; }
        public string SagData { get; set; }
        public double? SensorFromBit { get; set; }
        public double? ToolFaceAngle { get; set; }
        public double? BendAngle { get; set; }
        public double? DepthCorrection { get; set; }
        public string DepthReference { get; set; }
        public string IsStretchApplied { get; set; }
        public double? StretchFactor { get; set; }
        public string StretchFormula { get; set; }
        public string IsMerged { get; set; }
        public int? NumberMerged { get; set; }
        public string MergeToolIds { get; set; }
        public string MergeSurveyIds { get; set; }
        public double? MergeInterval { get; set; }
        public double? DirectionalDifficultyIndex { get; set; }
        public double? MaximumDlsValue { get; set; }
        public double? MaximumDlsDepth { get; set; }
        public double? Tortuosity { get; set; }
        public double? AverageDogleg { get; set; }
        public string ScanOffsetWell { get; set; }
        public string OffsetWellId { get; set; }

        public virtual CdWellboreT Well { get; set; }
        public virtual ICollection<CdSurveyStationT> CdSurveyStationT { get; set; }
    }
}
