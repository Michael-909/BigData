using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdCementStageT
    {
        public CdCementStageT()
        {
            CdCementFluidScheduleT = new HashSet<CdCementFluidScheduleT>();
            CdCementPlugStatusT = new HashSet<CdCementPlugStatusT>();
        }

        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string CementJobId { get; set; }
        public string CementStageId { get; set; }
        public string CementedWellboreId { get; set; }
        public double? CasingPressureFinal { get; set; }
        public double? CasingPressureInitial { get; set; }
        public double? CircDurationBefore { get; set; }
        public double? CircFlowrate { get; set; }
        public double? CircPress { get; set; }
        public string CementToolContractor { get; set; }
        public string CementToolDesc { get; set; }
        public double? CtuPressFinal { get; set; }
        public double? CtuPressInitial { get; set; }
        public double? TimePressureHeld { get; set; }
        public double? HoleSize { get; set; }
        public string HesitationReason { get; set; }
        public string IsBottomPlugUsed { get; set; }
        public string IsAnnPressHeld { get; set; }
        public string IsCoilTubingUsed { get; set; }
        public string IsPillBelowPlug { get; set; }
        public string IsHesitation { get; set; }
        public string IsPlugBumped { get; set; }
        public string IsPlugCatcherUsed { get; set; }
        public string IsPrimaryAnnularFlow { get; set; }
        public string IsPrimaryFloatHeld { get; set; }
        public string IsSqueezeGood { get; set; }
        public string IsTailPipePerfed { get; set; }
        public string IsSqueezePressHeld { get; set; }
        public string IsTailPipeUsed { get; set; }
        public string IsTopPlugUsed { get; set; }
        public double? MdBase { get; set; }
        public double? MdCementTool { get; set; }
        public double? MdCtu { get; set; }
        public double? MdPlugCirc { get; set; }
        public double? MdStageTool { get; set; }
        public double? MdTop { get; set; }
        public double? PressureHeld { get; set; }
        public double? PrimaryPressureBump { get; set; }
        public double? PrimaryPressurePriorBump { get; set; }
        public double? PrimaryVolumeReturns { get; set; }
        public string Returns { get; set; }
        public double? SqueezeBreakPress { get; set; }
        public double? SqueezeBreakRate { get; set; }
        public string SqueezeObjective { get; set; }
        public double? SqueezePressAvg { get; set; }
        public double? SqueezePressFinal { get; set; }
        public double? SqueezePumpRateAvg { get; set; }
        public double? SqueezePumpRateMax { get; set; }
        public double? SqueezePumpRateInitial { get; set; }
        public double? SqueezePumpRateFinal { get; set; }
        public double? SqueezePressHeldTime { get; set; }
        public double? SqueezeToolMd { get; set; }
        public double? SqueezeVolInCasing { get; set; }
        public double? SqueezeVolOutCasing { get; set; }
        public double? SqueezeVolReversed { get; set; }
        public short? StageNo { get; set; }
        public string StageToolDesc { get; set; }
        public string StageType { get; set; }
        public double? TailPipeSize { get; set; }
        public double? SqueezeWorkstringDepth { get; set; }
        public double? TubingPressFinal { get; set; }
        public double? TubingPressInitial { get; set; }
        public double? VolLost { get; set; }
        public double? WocTime { get; set; }
        public double? PrimaryReturnsSacks { get; set; }
        public double? ExcessVolume { get; set; }
        public double? ExcessPercent { get; set; }
        public double? TvdBase { get; set; }
        public double? TvdCementTool { get; set; }
        public double? TvdCtu { get; set; }
        public double? TvdPlugCirc { get; set; }
        public double? TvdStageTool { get; set; }
        public double? TvdTop { get; set; }
        public double? SqueezeToolTvd { get; set; }
        public double? SqueezeWorkstringTvd { get; set; }
        public int? SequenceNo { get; set; }
        public double? PressureRemaining { get; set; }
        public DateTime? PlugBumpedDate { get; set; }
        public DateTime? FloatHeldDate { get; set; }

        public virtual CdCementJobT CdCementJobT { get; set; }
        public virtual ICollection<CdCementFluidScheduleT> CdCementFluidScheduleT { get; set; }
        public virtual ICollection<CdCementPlugStatusT> CdCementPlugStatusT { get; set; }
    }
}
