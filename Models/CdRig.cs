using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdRig
    {
        public CdRig()
        {
            CdRigAnchor = new HashSet<CdRigAnchor>();
            CdRigCentrifuge = new HashSet<CdRigCentrifuge>();
            CdRigHydroclone = new HashSet<CdRigHydroclone>();
            CdRigPump = new HashSet<CdRigPump>();
            CdRigShaker = new HashSet<CdRigShaker>();
            DmRigOperation = new HashSet<DmRigOperation>();
            DmRiser = new HashSet<DmRiser>();
        }

        public string RigId { get; set; }
        public double? BopPressRating { get; set; }
        public string ContractorId { get; set; }
        public double? AirGap { get; set; }
        public string Approvals { get; set; }
        public string BopSystemSize { get; set; }
        public double? BulkMudCap { get; set; }
        public double? DrillWaterCap { get; set; }
        public double? FuelCap { get; set; }
        public string Remarks { get; set; }
        public double? BulkCementCapacity { get; set; }
        public double? LiquidMudCap { get; set; }
        public double? DefaultElevation { get; set; }
        public string CementUnit { get; set; }
        public string DefaultElevName { get; set; }
        public double? PotableWaterCap { get; set; }
        public string CraneType { get; set; }
        public double? DrillDepthRating { get; set; }
        public double? WaterDepthRating { get; set; }
        public string IsReadonly { get; set; }
        public string IsOffshore { get; set; }
        public short? NumCranes { get; set; }
        public string RigClass { get; set; }
        public string FlareDescription { get; set; }
        public string RigName { get; set; }
        public string RigOwner { get; set; }
        public string RigNo { get; set; }
        public string GantryDescription { get; set; }
        public string Generator { get; set; }
        public string RigType { get; set; }
        public double? VdlMax { get; set; }
        public double? HeaveMax { get; set; }
        public double? VdlStorm { get; set; }
        public short? WellsDrilled { get; set; }
        public string IsAzimuthing { get; set; }
        public DateTime? CreateDate { get; set; }
        public string MainEngine { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public double? MotionCompensationMin { get; set; }
        public string UpdateAppId { get; set; }
        public double? MotionCompensationMax { get; set; }
        public double? MotionCompensationStroke { get; set; }
        public short? NumDerricks { get; set; }
        public double? DerrickHeight { get; set; }
        public short? NumThrusters { get; set; }
        public string DerrickType { get; set; }
        public string Registration { get; set; }
        public double? DerrickRating { get; set; }
        public string RigManufacturer { get; set; }
        public double? DerrickWindCapacity { get; set; }
        public double? PipeStandLength { get; set; }
        public string DriveType { get; set; }
        public string RigYear { get; set; }
        public string DriveTypeDescription { get; set; }
        public string PipeHandlingSystem { get; set; }
        public string RotarySystemMake { get; set; }
        public string RotarySystemModel { get; set; }
        public double? RotarySystemOpeningSize { get; set; }
        public double? RotarySystemRating { get; set; }
        public double? RotarySystemTorque { get; set; }
        public string RotarySystemType { get; set; }
        public double? SwivelRating { get; set; }
        public string SwivelType { get; set; }
        public string BrakeDescription { get; set; }
        public string DrawWorksMotor { get; set; }
        public double? DrawWorksPower { get; set; }
        public string DrawWorksType { get; set; }
        public double? DrillLineRating { get; set; }
        public double? DrillLineSize { get; set; }
        public double? HookRating { get; set; }
        public string HookType { get; set; }
        public short? NumBlockLines { get; set; }
        public double? BlockRating { get; set; }
        public double? BlockWeight { get; set; }
        public double? MaxHookLoad { get; set; }
        public string ScrSystem { get; set; }
        public string MooringSystem { get; set; }
        public string MooringSystemCode { get; set; }
        public string RigMooringSystem { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string RigTypeCode { get; set; }

        public virtual ICollection<CdRigAnchor> CdRigAnchor { get; set; }
        public virtual ICollection<CdRigCentrifuge> CdRigCentrifuge { get; set; }
        public virtual ICollection<CdRigHydroclone> CdRigHydroclone { get; set; }
        public virtual ICollection<CdRigPump> CdRigPump { get; set; }
        public virtual ICollection<CdRigShaker> CdRigShaker { get; set; }
        public virtual ICollection<DmRigOperation> DmRigOperation { get; set; }
        public virtual ICollection<DmRiser> DmRiser { get; set; }
    }
}
