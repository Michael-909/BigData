using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmCrCleanupT
    {
        public DmCrCleanupT()
        {
            DmCrMudAdditiveT = new HashSet<DmCrMudAdditiveT>();
        }

        public string WellId { get; set; }
        public string EventId { get; set; }
        public string CleanupId { get; set; }
        public string ReportJournalId { get; set; }
        public string ForemanName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string GroundConditionInitial { get; set; }
        public string GroundConditionFinal { get; set; }
        public string CleanupComments { get; set; }
        public string CorrectiveMeasures { get; set; }
        public string BrushDisposalMethod { get; set; }
        public string BrushDisposalLocation { get; set; }
        public string IsSaltZone { get; set; }
        public string IsArtesianAquifer { get; set; }
        public string DisposalProblemDescription { get; set; }
        public string IsOffLeaseConsentObtained { get; set; }
        public string OffLeaseConsenterName { get; set; }
        public string OffLeaseConsenterPhone { get; set; }
        public string OffLeaseConditions { get; set; }
        public string AmendmentsForeman { get; set; }
        public string IsWorkDoneByLandowner { get; set; }
        public string WorkDoneByLandowner { get; set; }
        public DateTime? RecontourDate { get; set; }
        public string RecontourGroundCondition { get; set; }
        public string TurnoverTo { get; set; }
        public string IsSiteAccepted { get; set; }
        public DateTime? TurnoverAuthorizedDate { get; set; }
        public string IsWaterWellToRemain { get; set; }
        public string AgencyName { get; set; }
        public string AgencyContact { get; set; }
        public string AgencyContactPhone { get; set; }
        public string Contractor { get; set; }
        public string Supervisor { get; set; }
        public string LocationUwi { get; set; }
        public string RecordType { get; set; }
        public string RecordNumber { get; set; }
        public string LocationName { get; set; }
        public string LocationProvince { get; set; }
        public string EstimatedAmountUnit { get; set; }
        public string Packaging { get; set; }
        public string AssociatedDrillingEventId { get; set; }
        public string IsCleanupComplete { get; set; }
        public string OffLeaseDisposalContractor { get; set; }
        public double? EstimatedAmount { get; set; }
        public string DisposalComments { get; set; }
        public string Remarks { get; set; }
        public string OwnerComments { get; set; }
        public string RemoteLocation { get; set; }
        public string AcceptedByPhone { get; set; }
        public string AcceptedByPerson { get; set; }

        public virtual DmEventT DmEventT { get; set; }
        public virtual ICollection<DmCrMudAdditiveT> DmCrMudAdditiveT { get; set; }
    }
}
