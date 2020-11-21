using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdWellSource
    {
        public CdWellSource()
        {
            CdDatumT = new HashSet<CdDatumT>();
            CdWellStatusT = new HashSet<CdWellStatusT>();
            CdWellboreT = new HashSet<CdWellboreT>();
            DmEventT = new HashSet<DmEventT>();
            DmSupportVesselT = new HashSet<DmSupportVesselT>();
        }

        public string WellId { get; set; }
        public string SiteId { get; set; }
        public string TightGroupId { get; set; }
        public int? ActiveUiUnitsysId { get; set; }
        public short? CoordType { get; set; }
        public string ApiNo { get; set; }
        public string Battery { get; set; }
        public string Remarks { get; set; }
        public string CompletionWellId { get; set; }
        public string IsOffshore { get; set; }
        public string DatumName { get; set; }
        public string GeoDescription { get; set; }
        public double? GeoLatitude { get; set; }
        public double? GeoLongitude { get; set; }
        public string GeoOffsetReference { get; set; }
        public double? GeoOffsetEast { get; set; }
        public double? GeoOffsetNorth { get; set; }
        public string IsPlatform { get; set; }
        public string IsSubsea { get; set; }
        public string SlotName { get; set; }
        public DateTime? SpudDate { get; set; }
        public string LocCounty { get; set; }
        public string Reason { get; set; }
        public string LocCountry { get; set; }
        public short? UseSlotAsReference { get; set; }
        public string LocState { get; set; }
        public string WellCommonName { get; set; }
        public string IsReadonly { get; set; }
        public string WellDesc { get; set; }
        public double? SlotEw { get; set; }
        public string WellGeometry { get; set; }
        public double? SlotNs { get; set; }
        public string TargetFormation { get; set; }
        public string WellLegalName { get; set; }
        public double? SlotRadialError { get; set; }
        public string UnitSetOnCreate { get; set; }
        public double? WellheadDepth { get; set; }
        public double? WaterDepth { get; set; }
        public double? WellNetInt { get; set; }
        public double? Convergence { get; set; }
        public string WellOperator { get; set; }
        public string WellDescAlternate { get; set; }
        public string WellPurpose { get; set; }
        public string WellUwi { get; set; }
        public double? WellWorkingInt { get; set; }
        public DateTime? CreateDate { get; set; }
        public string WellOperatorOriginal { get; set; }
        public string WellUwiType { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public double? ScaleFactor { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public double? WrpAzimuth { get; set; }
        public double? WrpEw { get; set; }
        public double? WrpInclination { get; set; }
        public double? WrpMd { get; set; }
        public double? WrpNs { get; set; }
        public short? WrpOffset { get; set; }
        public double? WrpTvd { get; set; }
        public string RedrillNo { get; set; }
        public double? MaaspA { get; set; }
        public double? MaaspB { get; set; }
        public double? MaaspC { get; set; }
        public string IsH2sPresent { get; set; }
        public string IsLsaPresent { get; set; }
        public string IsProjectReadonly { get; set; }
        public string IsCo2Present { get; set; }
        public string RedrillPrevWellId { get; set; }
        public string PreviousWellName { get; set; }
        public string IsMultilateral { get; set; }
        public string IsLakeDrilled { get; set; }
        public double? LakeHeight { get; set; }
        public double? MaaspD { get; set; }
        public string LaheeClass { get; set; }
        public string FieldName { get; set; }
        public string PumperRoute { get; set; }
        public string WellDirections { get; set; }
        public string BatteryDirections { get; set; }
        public DateTime? ConductorInstallDate { get; set; }
        public string LeaseType { get; set; }
        public string FieldNumber { get; set; }
        public string UserDefined1 { get; set; }
        public string UserDefined2 { get; set; }
        public string UserDefined3 { get; set; }
        public string UserDefined4 { get; set; }
        public string UserDefined5 { get; set; }
        public string UserDefined6 { get; set; }
        public string UserDefined7 { get; set; }
        public string UserDefined8 { get; set; }
        public string UserDefined9 { get; set; }
        public string UserDefined10 { get; set; }
        public string UserDefined11 { get; set; }
        public string UserDefined12 { get; set; }
        public DateTime? UserDefinedDate1 { get; set; }
        public DateTime? UserDefinedDate2 { get; set; }
        public DateTime? UserDefinedDate3 { get; set; }
        public DateTime? UserDefinedDate4 { get; set; }
        public DateTime? UserDefinedDate5 { get; set; }
        public string RoadDescription { get; set; }

        public virtual CdSiteSource Site { get; set; }
        public virtual ICollection<CdDatumT> CdDatumT { get; set; }
        public virtual ICollection<CdWellStatusT> CdWellStatusT { get; set; }
        public virtual ICollection<CdWellboreT> CdWellboreT { get; set; }
        public virtual ICollection<DmEventT> DmEventT { get; set; }
        public virtual ICollection<DmSupportVesselT> DmSupportVesselT { get; set; }
    }
}
