using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdRigShaker
    {
        public CdRigShaker()
        {
            DmShakerscreen = new HashSet<DmShakerscreen>();
        }

        public string RigId { get; set; }
        public string ShakerId { get; set; }
        public short? CascadeLevel { get; set; }
        public DateTime? DateInstalled { get; set; }
        public DateTime? DateRemoved { get; set; }
        public string InstallLocation { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string IsMudCleaner { get; set; }
        public double? MaxFlow { get; set; }
        public short? NumberOfDecks { get; set; }
        public double? MinMeshSize { get; set; }
        public string Owner { get; set; }
        public string ShakerNo { get; set; }
        public string ShakerType { get; set; }
        public int? SequenceNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Remarks { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }

        public virtual CdRig Rig { get; set; }
        public virtual ICollection<DmShakerscreen> DmShakerscreen { get; set; }
    }
}
