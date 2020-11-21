using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmRiser
    {
        public string RigId { get; set; }
        public string Grade { get; set; }
        public double? Id { get; set; }
        public double? LengthAvailable { get; set; }
        public DateTime? DateInstalled { get; set; }
        public DateTime? DateRemoved { get; set; }
        public string Material { get; set; }
        public double? Od { get; set; }
        public string RiserId { get; set; }
        public string ConnectionType { get; set; }
        public string Make { get; set; }
        public int? SequenceNo { get; set; }
        public double? RiserAngleLimit { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Model { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public string Owner { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public string Remarks { get; set; }

        public virtual CdRig Rig { get; set; }
    }
}
