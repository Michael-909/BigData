using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdRigHydroclone
    {
        public string ConeType { get; set; }
        public string RigId { get; set; }
        public string HydrocloneId { get; set; }
        public DateTime? DateInstalled { get; set; }
        public string HydrocloneNo { get; set; }
        public DateTime? DateRemoved { get; set; }
        public string HydrocloneType { get; set; }
        public string IsMudCleaner { get; set; }
        public double? FlowCapacity { get; set; }
        public string Make { get; set; }
        public short? ConesNo { get; set; }
        public string Model { get; set; }
        public string Owner { get; set; }
        public double? ConeSize { get; set; }
        public int? SequenceNo { get; set; }
        public string Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Remarks { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }

        public virtual CdRig Rig { get; set; }
    }
}
