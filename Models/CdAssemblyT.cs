using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdAssemblyT
    {
        public CdAssemblyT()
        {
            CdAssemblyCompT = new HashSet<CdAssemblyCompT>();
            CdAssemblyDetailT = new HashSet<CdAssemblyDetailT>();
        }

        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string AssemblyId { get; set; }
        public string ReportJournalId { get; set; }
        public string Phase { get; set; }
        public string ConcentricAssemblyId { get; set; }
        public string StringType { get; set; }
        public string StringClass { get; set; }
        public DateTime? DateReport { get; set; }
        public string AssemblyName { get; set; }
        public double? AssemblySize { get; set; }
        public string AssemblyType { get; set; }
        public double? LengthTotal { get; set; }
        public string AssemblyNo { get; set; }
        public double? CasingCutOff { get; set; }
        public string IsParallel { get; set; }
        public double? PilotHoleSize { get; set; }
        public string IsCasingLiner { get; set; }
        public double? IdMin { get; set; }
        public double? HoleSize { get; set; }
        public double? OdMax { get; set; }
        public double? Overlap { get; set; }
        public short? PlanDepthType { get; set; }
        public double? MdSetDepthCorrection { get; set; }
        public string Remarks { get; set; }
        public double? MdAssemblyBase { get; set; }
        public double? TvdAssemblyBase { get; set; }
        public double? MdAssemblyTop { get; set; }
        public DateTime? CreateDate { get; set; }
        public string SuspPoint { get; set; }
        public string CreateUserId { get; set; }
        public double? SuspPointCorrection { get; set; }
        public double? MdToc { get; set; }
        public double? WeightAboveJars { get; set; }
        public string CreateAppId { get; set; }
        public double? WeightBelowJars { get; set; }
        public double? MudDensityShoe { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public double? TvdAssemblyTop { get; set; }
        public double? TvdToc { get; set; }
        public double? SetDayNo { get; set; }
        public double? CementDayNo { get; set; }
        public string PipeRunId { get; set; }
        public string EventId { get; set; }
        public string IsTopDown { get; set; }
        public double? RodSvcFactor { get; set; }
        public double? RodLoadFactor { get; set; }
        public string DesignLife { get; set; }
        public int? NoCompletionTrips { get; set; }
        public string SandControlEquipment { get; set; }
        public string ConcentricAssemblyWbId { get; set; }

        public virtual CdWellboreT Well { get; set; }
        public virtual ICollection<CdAssemblyCompT> CdAssemblyCompT { get; set; }
        public virtual ICollection<CdAssemblyDetailT> CdAssemblyDetailT { get; set; }
    }
}
