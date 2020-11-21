using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdBhaCompBitT
    {
        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string AssemblyId { get; set; }
        public string AssemblyCompId { get; set; }
        public string BitClass { get; set; }
        public string BitGroup { get; set; }
        public string BitNo { get; set; }
        public string BitDrive { get; set; }
        public string CurrencyUsed { get; set; }
        public double? BitSizePassThrough { get; set; }
        public double? ExchangeRate { get; set; }
        public double? BitSizePilot { get; set; }
        public double? HoursOnBit { get; set; }
        public string IadcBearing { get; set; }
        public string IadcCode { get; set; }
        public string IadcDull { get; set; }
        public string IadcGauge { get; set; }
        public string IadcInner { get; set; }
        public string IadcLocation { get; set; }
        public string IadcOther { get; set; }
        public string IadcOuter { get; set; }
        public string IadcReasonPulled { get; set; }
        public string IsLeftInWell { get; set; }
        public double? BitSize { get; set; }
        public string Remarks { get; set; }
        public string RerunNo { get; set; }

        public virtual CdAssemblyCompT CdAssemblyCompT { get; set; }
    }
}
