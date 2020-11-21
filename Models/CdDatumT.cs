using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdDatumT
    {
        public string DatumId { get; set; }
        public string WellId { get; set; }
        public short? DatumType { get; set; }
        public string Phase { get; set; }
        public double? DatumElevation { get; set; }
        public string RigId { get; set; }
        public double? DatumError { get; set; }
        public string DatumDescription { get; set; }
        public DateTime? DateEstablished { get; set; }
        public string DatumName { get; set; }
        public string Remarks { get; set; }
        public string IsDefault { get; set; }
        public int? SequenceNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public string ContractorId { get; set; }

        public virtual CdWellSource Well { get; set; }
    }
}
