using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdDefinitiveSurveyHeaderT
    {
        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string DefSurveyHeaderId { get; set; }
        public string Phase { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public DateTime? CreateDate { get; set; }
        public string BRange { get; set; }
        public double? BhMd { get; set; }
        public string BRatio { get; set; }
        public string Interpolate { get; set; }
        public string BInterp { get; set; }
        public double? BhTvd { get; set; }
        public string CreateUserId { get; set; }
        public double? InterpolationInterval { get; set; }
        public string Name { get; set; }
        public short? DefinitivePath { get; set; }
        public string CreateAppId { get; set; }
        public double? DefinitiveVersion { get; set; }
        public DateTime? UpdateDate { get; set; }
        public double? PlannedAzimuth { get; set; }
        public double? FinalEast { get; set; }
        public double? FinalError { get; set; }
        public string UpdateUserId { get; set; }
        public double? KoEast { get; set; }
        public double? KoNorth { get; set; }
        public string IsReadonly { get; set; }
        public double? FinalNorth { get; set; }
        public double? TortuosityPeriod { get; set; }
        public string UpdateAppId { get; set; }
        public string Remarks { get; set; }
        public short? TortuosityType { get; set; }
        public string IsDefinitive { get; set; }
        public double? KoMd { get; set; }
        public double? KoTvd { get; set; }
        public double? VsEast { get; set; }
        public double? VsNorth { get; set; }
        public string UsePlannedProgram { get; set; }
        public double? AcscanMdMin { get; set; }
        public double? AcscanMdMax { get; set; }
        public double? AcscanRadiusMax { get; set; }
        public double? AcscanRatioMax { get; set; }
        public string UseActualData { get; set; }
        public double? DirectionalDifficultyIndex { get; set; }
        public double? MaximumDlsValue { get; set; }
        public double? MaximumDlsDepth { get; set; }
        public double? Tortuosity { get; set; }
        public double? AverageDogleg { get; set; }
        public string IsSurveyProgramReadOnly { get; set; }

        public virtual CdWellboreT Well { get; set; }
    }
}
