using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdSiteSource
    {
        public CdSiteSource()
        {
            CdWellSource = new HashSet<CdWellSource>();
        }

        public string SiteId { get; set; }
        public string ProjectId { get; set; }
        public string TimeZoneDescription { get; set; }
        public double? TimeZone { get; set; }
        public string TightGroupId { get; set; }
        public short? NorthType { get; set; }
        public string LocationId { get; set; }
        public string SiteName { get; set; }
        public string BlockName { get; set; }
        public string DistrictName { get; set; }
        public string LocCountry { get; set; }
        public double? Convergence { get; set; }
        public string LocCounty { get; set; }
        public double? DefaultRigElevation { get; set; }
        public string SiteLocDesc { get; set; }
        public double? TopBoreholeRadius { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string IsFieldCenter { get; set; }
        public string LocDivision { get; set; }
        public string IsReadonly { get; set; }
        public double? LateralError { get; set; }
        public string LocFedLeaseNo { get; set; }
        public string CreateAppId { get; set; }
        public short? CoordType { get; set; }
        public string LocLeaseCode { get; set; }
        public double? GeoLatitude { get; set; }
        public DateTime? UpdateDate { get; set; }
        public double? ForesightError { get; set; }
        public string LocRegion { get; set; }
        public double? MagCrustalTotal { get; set; }
        public string RoadDescription { get; set; }
        public string UpdateUserId { get; set; }
        public double? MagCrustalDip { get; set; }
        public double? GeoLongitude { get; set; }
        public double? MagCrustalDec { get; set; }
        public string LocState { get; set; }
        public double? MagTimeTotal { get; set; }
        public string StateDistrictNo { get; set; }
        public double? MagTimeDip { get; set; }
        public double? GeoMapEasting { get; set; }
        public double? MagTimeDec { get; set; }
        public string UpdateAppId { get; set; }
        public double? GeoMapNorthing { get; set; }
        public double? ScaleFactor { get; set; }
        public double? GeoOffsetEastLeaseLine { get; set; }
        public double? GeoOffsetNorthLeaseLine { get; set; }
        public string Remarks { get; set; }
        public double? PermafrostThickness { get; set; }
        public short? SiteType { get; set; }
        public string IsProjectReadonly { get; set; }
        public string IsFacility { get; set; }

        public virtual CdProjectSource Project { get; set; }
        public virtual ICollection<CdWellSource> CdWellSource { get; set; }
    }
}
