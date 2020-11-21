using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmBhaRunT
    {
        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string AssemblyId { get; set; }
        public string BhaRunId { get; set; }
        public string Purpose { get; set; }
        public string Comments { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public string IsLeftInHole { get; set; }
        public string PerformanceActual { get; set; }
        public string PerformancePredicted { get; set; }
        public double? MdIn { get; set; }
        public double? TripTimeIn { get; set; }
        public double? TripTimeOut { get; set; }
        public double? MdOut { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public string IsNuclearSource { get; set; }
        public string Description { get; set; }
        public string Phase { get; set; }
        public string ScenarioId { get; set; }
        public double? DailySlidingFootage { get; set; }
        public double? DailyRotatingFootage { get; set; }
        public double? DailySlidingHours { get; set; }
        public double? DailyRotatingHours { get; set; }

        public virtual CdWellboreT Well { get; set; }
    }
}
