using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdFluidT
    {
        public CdFluidT()
        {
            CdVgMeterT = new HashSet<CdVgMeterT>();
        }

        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public double? Act { get; set; }
        public string Phase { get; set; }
        public double? ApiWaterLoss { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public double? ConcCaWholeMud { get; set; }
        public double? Agno3 { get; set; }
        public string CompanyName { get; set; }
        public double? CecShale { get; set; }
        public double? ConcClWholeMud { get; set; }
        public string Remarks { get; set; }
        public double? ConcBicarbonate { get; set; }
        public double? ConcCa { get; set; }
        public double? ConcCacl { get; set; }
        public double? MixwaterDensity { get; set; }
        public double? ConcCarbonate { get; set; }
        public double? ConcCl { get; set; }
        public double? ConcExcessLime { get; set; }
        public double? ConcH2s { get; set; }
        public double? ConcHighGravitySolids { get; set; }
        public double? ConcLostCirculationMaterial { get; set; }
        public double? ConcLowGravitySolidsCorr { get; set; }
        public double? ConcLowGravitySolids { get; set; }
        public double? ConcMagnesium { get; set; }
        public double? ConcPolymer { get; set; }
        public double? ConcPotassium { get; set; }
        public double? ConcSand { get; set; }
        public double? ConcNacl { get; set; }
        public double? ConcSulfides { get; set; }
        public DateTime? CheckDate { get; set; }
        public double? CumMudAge { get; set; }
        public double? Density { get; set; }
        public double? Ecd { get; set; }
        public double? TestEquipEfficiency { get; set; }
        public double? ElectrostaticStability { get; set; }
        public double? FiltrateMethylEndPoint { get; set; }
        public double? PfEndPoint { get; set; }
        public double? FilterCake { get; set; }
        public double? Edta { get; set; }
        public string FieldName { get; set; }
        public string FluidName { get; set; }
        public double? FluidExpansion { get; set; }
        public double? Gels10Min { get; set; }
        public double? Gels10Sec { get; set; }
        public double? Gels30Min { get; set; }
        public short? FannDataSource { get; set; }
        public double? HthpFilterCake { get; set; }
        public double? HthpWaterLoss { get; set; }
        public double? HthpTemp { get; set; }
        public string IsMudChanged { get; set; }
        public string IsUnderbalanced { get; set; }
        public string SampleSource { get; set; }
        public double? Gels0Sec { get; set; }
        public double? H2so4 { get; set; }
        public double? Mbt { get; set; }
        public double? HthpWlPress { get; set; }
        public double? KPrimeParameter { get; set; }
        public string MudEngineer { get; set; }
        public string FluidId { get; set; }
        public double? NPrimeParameter { get; set; }
        public short? Method { get; set; }
        public string MudSupplier { get; set; }
        public string IsCement { get; set; }
        public double? PercentWater { get; set; }
        public double? Lsrv1 { get; set; }
        public double? Lsrv2 { get; set; }
        public short? IsSpacerFluid { get; set; }
        public double? PercentOil { get; set; }
        public double? Lsrv3 { get; set; }
        public double? PercentOilOnCuttings { get; set; }
        public double? MudbaseDensity { get; set; }
        public double? PercentSolidsCorrCl { get; set; }
        public short? MudbaseType { get; set; }
        public double? PercentHighGravitySolids { get; set; }
        public double? PercentLowGravitySolids { get; set; }
        public double? Ph { get; set; }
        public double? PlasticViscosity { get; set; }
        public double? Pm { get; set; }
        public double? Pom { get; set; }
        public double? SolidsSgAvg { get; set; }
        public double? TotalDissolvedSolids { get; set; }
        public double? PercentLubricant { get; set; }
        public double? TotalDrillingSolids { get; set; }
        public double? TempFlowline { get; set; }
        public double? TempVgMeter { get; set; }
        public DateTime? TimeOilCutSample { get; set; }
        public double? MdMudSample { get; set; }
        public double? MdOilCuttings { get; set; }
        public double? ResistivityMud { get; set; }
        public double? PorePressure { get; set; }
        public double? HardnessTotal { get; set; }
        public double? ResistivityMudTemp { get; set; }
        public string TypeMudSystem { get; set; }
        public double? ResistivityMudCake { get; set; }
        public short? RheologyModel { get; set; }
        public double? ResistivityMudCakeTemp { get; set; }
        public string TypePolymer { get; set; }
        public double? ResistivityMudFiltrate { get; set; }
        public string CustomLabel1 { get; set; }
        public double? ResistivityMudFiltrateTemp { get; set; }
        public string CustomLabel2 { get; set; }
        public double? TempDensity { get; set; }
        public double? CustomValue1 { get; set; }
        public double? TempRheology { get; set; }
        public double? CustomValue2 { get; set; }
        public double? ViscosityFunnel { get; set; }
        public double? OwrWater { get; set; }
        public double? TvdMudSample { get; set; }
        public double? VolWaterUsed { get; set; }
        public double? VolMudUsed { get; set; }
        public double? TvdOilCuttings { get; set; }
        public double? OwrOil { get; set; }
        public double? VolCuttingsOil { get; set; }
        public double? VolBaseMudOil { get; set; }
        public double? WaterRequirement { get; set; }
        public double? YieldPoint { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public double? Wps { get; set; }
        public string UpdateAppId { get; set; }
        public double? Yield { get; set; }
        public string IsFoamed { get; set; }
        public string Class { get; set; }
        public string IsDesign { get; set; }
        public double? AlkalinityPoint1 { get; set; }
        public double? AlkalinityPoint2 { get; set; }
        public double? Turbidity { get; set; }
        public string CustomBaseFluid { get; set; }
        public string IsArtesianAquifer { get; set; }
        public string IsSaltZone { get; set; }
        public string BrineType { get; set; }
        public string BrineTypeCode { get; set; }
        public double? Tct { get; set; }
        public double? BrineSg { get; set; }
        public double? BrineSgTemp { get; set; }
        public double? BrineTurbidity { get; set; }
        public double? BrineIronConc { get; set; }
        public double? Barite { get; set; }
        public double? Pct { get; set; }
        public double? SolubleNacl { get; set; }
        public double? InsolubleNacl { get; set; }
        public string IsRecalcRequired { get; set; }

        public virtual CdWellboreT Well { get; set; }
        public virtual ICollection<CdVgMeterT> CdVgMeterT { get; set; }
    }
}
