using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmRigOperation
    {
        public string Remarks { get; set; }
        public string RigId { get; set; }
        public double? ContractMaxDays { get; set; }
        public string NextSiteId { get; set; }
        public string NextWellId { get; set; }
        public string ContractNo { get; set; }
        public double? AirGap { get; set; }
        public string ContractId { get; set; }
        public double? ContractRate { get; set; }
        public string ContractType { get; set; }
        public string ContractReference { get; set; }
        public string RigOperationId { get; set; }
        public DateTime? DateTimeChargeStart { get; set; }
        public DateTime? DateContract { get; set; }
        public DateTime? DateEffective { get; set; }
        public DateTime? DateTimeOffLocation { get; set; }
        public DateTime? DateTimeOnLocation { get; set; }
        public DateTime? DateTimeOpsFinished { get; set; }
        public string RigManager { get; set; }
        public DateTime? DateTimeOpsStart { get; set; }
        public DateTime? DateRigPickup { get; set; }
        public string IsDrillCapable { get; set; }
        public DateTime? DateRigReleased { get; set; }
        public DateTime? DateRigDown { get; set; }
        public DateTime? DateRigUp { get; set; }
        public double? FreqBopTest { get; set; }
        public string IsReadonly { get; set; }
        public double? RiserLengthUsed { get; set; }
        public string PerformanceRating { get; set; }
        public string RigEmail { get; set; }
        public short? NumBeds { get; set; }
        public string RigPhone1 { get; set; }
        public string RigPhone2 { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public string NextWellName { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string NextWellLocation { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public string IsHelipadReady { get; set; }
        public string IsHelipadInspected { get; set; }
        public string IsRoadReady { get; set; }
        public string IsRoadInspected { get; set; }
        public double? DrillDays { get; set; }
        public string OperationType { get; set; }

        public virtual CdRig Rig { get; set; }
    }
}
