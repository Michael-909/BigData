using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmDailyNotificationT
    {
        public string WellId { get; set; }
        public string EventId { get; set; }
        public string DailyId { get; set; }
        public string DailyNotificationId { get; set; }
        public int? SequenceNo { get; set; }
        public DateTime? NotificationDate { get; set; }
        public string NotificationType { get; set; }
        public string Engineer { get; set; }
        public string Agency { get; set; }
        public string AgencyContact { get; set; }
        public string Comments { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
