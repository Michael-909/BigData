using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdProjectSource
    {
        public CdProjectSource()
        {
            CdSiteSource = new HashSet<CdSiteSource>();
        }

        public string ProjectId { get; set; }
        public string PolicyId { get; set; }
        public string TimeZoneDescription { get; set; }
        public double? TimeZone { get; set; }
        public string GeoSystemId { get; set; }
        public short? FieldNo { get; set; }
        public string GeoZoneId { get; set; }
        public string GeoDatumId { get; set; }
        public string ProjectName { get; set; }
        public string DefMagModel { get; set; }
        public short? LocalCoordOrigin { get; set; }
        public string ProjectCode { get; set; }
        public string Description { get; set; }
        public string DescriptionSupplement { get; set; }
        public string MagCalcModel { get; set; }
        public string Remarks { get; set; }
        public short? UseLocalScaleFactor { get; set; }
        public short? VerticalCoordOrigin { get; set; }
        public string StateNo { get; set; }
        public string SystemDatumDesc { get; set; }
        public double? SystemDatumOffset { get; set; }
        public string IsReadonly { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public string UseRisk { get; set; }
        public double? RiskFactor { get; set; }
        public double? RiskDepth { get; set; }
        public string TightGroupId { get; set; }
        public string ProjectPassword { get; set; }
        public string IsProjectReadonly { get; set; }
        public string BasinName { get; set; }
        public string IsFacility { get; set; }
        public int? ActiveUiUnitsysId { get; set; }
        public string UseVariableConvergence { get; set; }
        public string TemplateId { get; set; }

        public virtual CdPolicy Policy { get; set; }
        public virtual ICollection<CdSiteSource> CdSiteSource { get; set; }
    }
}
