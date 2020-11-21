using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmPersonnelT
    {
        public string WellId { get; set; }
        public string EventId { get; set; }
        public string PersonnelId { get; set; }
        public string RigId { get; set; }
        public string RigOperationId { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public string Duties { get; set; }
        public string EmployeeNo { get; set; }
        public double? EmployeeWeight { get; set; }
        public string EmployeeName { get; set; }
        public string JobTitle { get; set; }
        public string SocialSecurityNo { get; set; }
        public string CompanyId { get; set; }
        public string Service { get; set; }
        public DateTime? DateArrived { get; set; }
        public DateTime? DateDeparted { get; set; }
        public string LifeboatNo { get; set; }
        public string RoomNo { get; set; }
        public double? LuggageWeight { get; set; }
        public string SquadMember { get; set; }
        public double? PayRate { get; set; }
        public string Catering { get; set; }
        public string Crew { get; set; }
        public int? SequenceNo { get; set; }

        public virtual DmEventT DmEventT { get; set; }
    }
}
