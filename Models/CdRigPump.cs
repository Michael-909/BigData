using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdRigPump
    {
        public string RigId { get; set; }
        public double? StrokeLength { get; set; }
        public string Make { get; set; }
        public string MotorId { get; set; }
        public short? Action { get; set; }
        public double? DampenerPressure { get; set; }
        public DateTime? DateInstalled { get; set; }
        public string Model { get; set; }
        public DateTime? DateRemoved { get; set; }
        public double? Efficiency { get; set; }
        public string IsDoubleActing { get; set; }
        public short? NumCylinders { get; set; }
        public double? RodOd { get; set; }
        public double? IdLiner { get; set; }
        public string Owner { get; set; }
        public double? MaxPower { get; set; }
        public string PumpId { get; set; }
        public int? SequenceNo { get; set; }
        public double? MaxPressure { get; set; }
        public string PumpNo { get; set; }
        public string SuperchargerMake { get; set; }
        public string SuperchargerModel { get; set; }
        public double? MaxSpm { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Type { get; set; }
        public string Remarks { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public double? StrokeDisplacement { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public string Purpose { get; set; }

        public virtual CdRig Rig { get; set; }
    }
}
