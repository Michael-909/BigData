using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmReportJournalRepository
    {
        private readonly jv_edm_dbContext dbContext;
        public DmReportJournalRepository()
        {
            dbContext = new jv_edm_dbContext();
        }
        public IEnumerable<DmReportJournal> GetRows()
        {
            return dbContext.DmReportJournal.Select(x => x).ToList();
        }
        public bool Create(DmReportJournal data)
        {
            data.ReportJournalId = NormalHelper.GenerateNormalKey();
            dbContext.DmReportJournal.Add(data);
            return dbContext.SaveChanges() > 0;
        }
        public bool Update(string Id, DmReportJournal data)
        {
            var old = dbContext.DmReportJournal.SingleOrDefault(x => x.ReportJournalId == Id);
            if (old == null) return false;
            old = data;
            dbContext.DmReportJournal.Update(old);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmReportJournal.Where(x => x.ReportJournalId == Id);
            dbContext.DmReportJournal.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
