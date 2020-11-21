using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdWellboreT
    {
        public CdWellboreT()
        {
            CdAssemblyT = new HashSet<CdAssemblyT>();
            CdCementJobT = new HashSet<CdCementJobT>();
            CdDefinitiveSurveyHeaderT = new HashSet<CdDefinitiveSurveyHeaderT>();
            CdFluidT = new HashSet<CdFluidT>();
            CdHoleSectGroupT = new HashSet<CdHoleSectGroupT>();
            CdPerforateT = new HashSet<CdPerforateT>();
            CdSurveyHeaderT = new HashSet<CdSurveyHeaderT>();
            CdWellboreFormationT = new HashSet<CdWellboreFormationT>();
            DmBhaRunT = new HashSet<DmBhaRunT>();
        }

        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string TightGroupId { get; set; }
        public string ConnectionId { get; set; }
        public string WellboreTypePolicyId { get; set; }
        public string ApiSuffix { get; set; }
        public string WellboreTypeId { get; set; }
        public string Remarks { get; set; }
        public DateTime? KoDate { get; set; }
        public double? AuthorizedMd { get; set; }
        public string Phase { get; set; }
        public double? AuthorizedTvd { get; set; }
        public short? BRatio { get; set; }
        public double? BhMd { get; set; }
        public double? BhTvd { get; set; }
        public string GeoDescriptionBh { get; set; }
        public string ParentWellboreId { get; set; }
        public string GeoOffsetReferenceBh { get; set; }
        public string IsDeviated { get; set; }
        public double? BudgetedMd { get; set; }
        public double? GeoOffsetEastBh { get; set; }
        public double? BudgetedTvd { get; set; }
        public double? GeoOffsetNorthBh { get; set; }
        public string GeologicalPlay { get; set; }
        public string GovernmentNo { get; set; }
        public double? GeoLatitudeBh { get; set; }
        public double? GeoLongitudeBh { get; set; }
        public short? BRange { get; set; }
        public string GeoDescriptionKo { get; set; }
        public string GeoOffsetReferenceKo { get; set; }
        public double? GeoOffsetEastKo { get; set; }
        public string Reason { get; set; }
        public double? GeoOffsetNorthKo { get; set; }
        public double? GeoLatitudeKo { get; set; }
        public double? KoMd { get; set; }
        public double? KoTvd { get; set; }
        public double? GeoLongitudeKo { get; set; }
        public string EndStatus { get; set; }
        public string WellboreLabel { get; set; }
        public string WellLegalName { get; set; }
        public string LicenseNo { get; set; }
        public double? PlugbackMd { get; set; }
        public string Interpolate { get; set; }
        public string WellboreName { get; set; }
        public double? PlugbackTvd { get; set; }
        public double? InterpolationInterval { get; set; }
        public string Redrill { get; set; }
        public DateTime? LicenseDate { get; set; }
        public string IsReadonly { get; set; }
        public string WellboreNo { get; set; }
        public string Licensee { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public short? WellpathType { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public string RigName { get; set; }
        public string OwWellUwi { get; set; }
        public string ExternalWellId { get; set; }
        public string ApiNo { get; set; }
        public string WellboreUwi { get; set; }
        public string IsProjectReadonly { get; set; }
        public string DefaultFluidId { get; set; }
        public string IsLocator { get; set; }
        public string IsProductionCapable { get; set; }
        public string TamlClass { get; set; }
        public string IsContingencySidetrack { get; set; }
        public string IsHighTemp { get; set; }
        public string IsHighPressure { get; set; }
        public string IsExceptional { get; set; }
        public string IsComplex { get; set; }
        public string IsUnderbalanced { get; set; }
        public string IsOfflineSlotRecovery { get; set; }
        public string IsSubSalt { get; set; }
        public string NewTechniques { get; set; }
        public string BatchSetCode { get; set; }
        public double? HorizontalLength { get; set; }
        public double? SubSaltTopTvd { get; set; }
        public double? SubSaltBaseTvd { get; set; }
        public DateTime? DateTdReached { get; set; }
        public string ConductorSetByDrillRig { get; set; }
        public int? TypicalSchematicType { get; set; }
        public double? RtSampleDepthInterval { get; set; }
        public string IsManagedPressure { get; set; }
        public string IsMechanicalSidetrack { get; set; }
        public string PlayType { get; set; }
        public double? UserDefinedDepth1 { get; set; }
        public double? UserDefinedDepth2 { get; set; }
        public double? BottomHoleTemp { get; set; }

        public virtual CdWellSource Well { get; set; }
        public virtual ICollection<CdAssemblyT> CdAssemblyT { get; set; }
        public virtual ICollection<CdCementJobT> CdCementJobT { get; set; }
        public virtual ICollection<CdDefinitiveSurveyHeaderT> CdDefinitiveSurveyHeaderT { get; set; }
        public virtual ICollection<CdFluidT> CdFluidT { get; set; }
        public virtual ICollection<CdHoleSectGroupT> CdHoleSectGroupT { get; set; }
        public virtual ICollection<CdPerforateT> CdPerforateT { get; set; }
        public virtual ICollection<CdSurveyHeaderT> CdSurveyHeaderT { get; set; }
        public virtual ICollection<CdWellboreFormationT> CdWellboreFormationT { get; set; }
        public virtual ICollection<DmBhaRunT> DmBhaRunT { get; set; }
    }
}
