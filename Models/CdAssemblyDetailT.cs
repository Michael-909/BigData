using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdAssemblyDetailT
    {
        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string AssemblyId { get; set; }
        public string AssemblyDetailId { get; set; }
        public int? SequenceNo { get; set; }
        public string TubingDesc { get; set; }
        public double? MdTop { get; set; }
        public double? MdBase { get; set; }
        public double? OdBody { get; set; }
        public double? IdBody { get; set; }
        public double? IdDrift { get; set; }
        public string ConnectionName { get; set; }
        public double? OdConnection { get; set; }
        public double? IdConnection { get; set; }
        public double? PressureBurst { get; set; }
        public double? PressureCollapse { get; set; }
        public double? YieldStrength { get; set; }
        public double? LinearCapacity { get; set; }
        public double? ApproximateWeight { get; set; }
        public string GradeId { get; set; }
        public string Comments1 { get; set; }
        public string Comments2 { get; set; }

        public virtual CdAssemblyT CdAssemblyT { get; set; }
    }
}
