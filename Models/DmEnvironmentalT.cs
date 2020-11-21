using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmEnvironmentalT
    {
        public string WellId { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public string EnvironmentalId { get; set; }
        public string TfmCompany { get; set; }
        public double? ChokeLineVolume { get; set; }
        public double? KillLineVolume { get; set; }
        public string TfmEngineer { get; set; }
        public double? TfmLostTime { get; set; }
        public DateTime? BoatCleanedDate { get; set; }
        public DateTime? RigCleanedDate { get; set; }
        public string VisualSheenObserved { get; set; }
        public string DomesticWasteFloatingSolids { get; set; }
        public string SewageFloatingSolids { get; set; }
        public string Remarks { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
