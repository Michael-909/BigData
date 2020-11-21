using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdHoleSectGroupT
    {
        public CdHoleSectGroupT()
        {
            CdHoleSectT = new HashSet<CdHoleSectT>();
            DmWellboreIntegT = new HashSet<DmWellboreIntegT>();
        }

        public string WellId { get; set; }
        public string WellboreId { get; set; }
        public string LastCasingCoupling { get; set; }
        public string HoleSectGroupId { get; set; }
        public string Phase { get; set; }
        public string HoleName { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Grade { get; set; }
        public DateTime? DateSectEnd { get; set; }
        public double? LastCasingId { get; set; }
        public string CreateUserId { get; set; }
        public DateTime? DateSectStart { get; set; }
        public string CreateAppId { get; set; }
        public string IsLiner { get; set; }
        public DateTime? UpdateDate { get; set; }
        public double? LastCasingOd { get; set; }
        public double? TvdHoleSectBase { get; set; }
        public double? LastCasingBurstPressure { get; set; }
        public double? TvdHoleSectTop { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }
        public double? MdCasingBottom { get; set; }
        public double? MdCasingTop { get; set; }
        public string IsPilotHole { get; set; }
        public double? MdHoleSectBase { get; set; }
        public double? MdHoleSectTop { get; set; }
        public double? NextCasingOd { get; set; }
        public double? TvdCasingBottom { get; set; }
        public double? NextCasingSetMd { get; set; }
        public double? NextCasingSetTvd { get; set; }
        public double? LastCasingWeight { get; set; }
        public double? PlanMd { get; set; }
        public double? PlanTvd { get; set; }
        public string EventId { get; set; }
        public string ActivityDrlPhase { get; set; }
        public string ActivityCsgPhase { get; set; }
        public string IsReadonly { get; set; }

        public virtual CdWellboreT Well { get; set; }
        public virtual ICollection<CdHoleSectT> CdHoleSectT { get; set; }
        public virtual ICollection<DmWellboreIntegT> DmWellboreIntegT { get; set; }
    }
}
