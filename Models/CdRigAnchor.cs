using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdRigAnchor
    {
        public string AnchorId { get; set; }
        public string RigId { get; set; }
        public string AnchorNo { get; set; }
        public string Remarks { get; set; }
        public string IsInUse { get; set; }
        public string AnchorLocation { get; set; }
        public double? AnchorRating { get; set; }
        public string Make { get; set; }
        public double? ChainRating { get; set; }
        public double? CouplingRating { get; set; }
        public string Model { get; set; }
        public string AnchorType { get; set; }
        public double? LineRating { get; set; }
        public int? SequenceNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }

        public virtual CdRig Rig { get; set; }
    }
}
