using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdHoleSectT
    {
        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string HoleSectGroupId { get; set; }
        public string HoleSectId { get; set; }
        public string AssemblyId { get; set; }
        public double? IdCasing { get; set; }
        public string SectTypeCode { get; set; }
        public double? OdCasing { get; set; }
        public string CompTypeCode { get; set; }
        public double? HoleSize { get; set; }
        public int? SequenceNo { get; set; }
        public string CatalogKeyDesc { get; set; }
        public double? Cof { get; set; }
        public double? LinearCapacity { get; set; }
        public double? EffectiveDiameter { get; set; }
        public double? IdDrift { get; set; }
        public double? Length { get; set; }
        public double? VolumeExcess { get; set; }
        public double? OpenHoleSize { get; set; }
        public string IsTapered { get; set; }
        public double? MdShoe { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double? WearLimit { get; set; }

        public virtual CdHoleSectGroupT CdHoleSectGroupT { get; set; }
    }
}
