using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class CdWellStatusT
    {
        public string WellId { get; set; }
        public string WellStatusId { get; set; }
        public DateTime? StatusDate { get; set; }
        public string Comments { get; set; }
        public string CompletionType { get; set; }
        public int? SequenceNo { get; set; }
        public string StatusType { get; set; }
        public string StatusDesc { get; set; }
        public DateTime? CreateDate { get; set; }
        public string WellType { get; set; }
        public string CreateUserId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateAppId { get; set; }

        public virtual CdWellSource Well { get; set; }
    }
}
