using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdWellboreFormationT
    {
        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string WellboreFormationId { get; set; }
        public string LithologyId { get; set; }
        public string StratUnitId { get; set; }
        public string Phase { get; set; }
        public double? DipAngle { get; set; }
        public double? DipDirection { get; set; }
        public string AgeCode { get; set; }
        public double? BitLife { get; set; }
        public string BitType { get; set; }
        public string Comments { get; set; }
        public string FormationName { get; set; }
        public int? SequenceNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public short? PrognosedDepthType { get; set; }
        public double? PrognosedMd { get; set; }
        public double? PrognosedBaseMd { get; set; }
        public double? PrognosedBaseTvd { get; set; }
        public double? PrognosedMdSubsea { get; set; }
        public string CompetentLayer { get; set; }
        public double? PrognosedTvdSubsea { get; set; }
        public string CreateAppId { get; set; }
        public string PrognosedLithology { get; set; }
        public double? PrognosedBaseMdSubsea { get; set; }
        public DateTime? UpdateDate { get; set; }
        public double? PrognosedBaseTvdSubsea { get; set; }
        public double? OverbalanceMargin { get; set; }
        public double? PrognosedTvd { get; set; }
        public double? DiffStickingLimit { get; set; }
        public string UpdateUserId { get; set; }
        public double? RateOfPenetration { get; set; }
        public string UpdateAppId { get; set; }
        public double? Porosity { get; set; }
        public double? Permeability { get; set; }
        public string IsPermeable { get; set; }
        public double? FormationDensity { get; set; }
        public double? SpecificHeat { get; set; }
        public double? Conductivity { get; set; }
        public double? FrozenDensity { get; set; }
        public double? StabilityMinMw { get; set; }
        public double? FrozenConductivity { get; set; }
        public double? MeltingPoint { get; set; }
        public double? HeatOfFusion { get; set; }
        public double? PrognosedUncertainty { get; set; }
        public double? StartGeoMapNorthing { get; set; }
        public double? StartGeoMapEasting { get; set; }
        public double? EndGeoMapNorthing { get; set; }
        public double? EndGeoMapEasting { get; set; }
        public double? PrognosedTvdEnd { get; set; }
        public string ProjectId { get; set; }
        public string SurfaceId { get; set; }
        public double? FormationNetPay { get; set; }
        public string ReservoirId { get; set; }
        public double? ElasticModulus { get; set; }
        public double? PoissonsRatio { get; set; }

        public virtual CdWellboreT Well { get; set; }
    }
}
