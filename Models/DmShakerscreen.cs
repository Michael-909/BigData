using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmShakerscreen
    {
        public string RigId { get; set; }
        public string CutPoint { get; set; }
        public string ShakerId { get; set; }
        public string Disposition { get; set; }
        public string IsInUse { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Owner { get; set; }
        public DateTime? DateRemoved { get; set; }
        public string ScreenNo { get; set; }
        public string ShakerscreenId { get; set; }
        public DateTime? DateInstalled { get; set; }
        public string ApiSize { get; set; }
        public double? SizeMeshX { get; set; }
        public double? SizeMeshY { get; set; }
        public string Supplier { get; set; }
        public string SerialNo { get; set; }
        public double? SizeMeshZ { get; set; }

        public virtual CdRigShaker CdRigShaker { get; set; }
    }
}
