using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdPerforateTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdPerforateTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdPerforateT> GetRows()
        {
            return dbContext.CdPerforateT.Select(x => x).ToList();
        }

        public bool Create(CdPerforateT data)
        {
            data.PerfId = NormalHelper.GenerateNormalKey();
            dbContext.CdPerforateT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdPerforateT data)
        {
            var model = dbContext.CdPerforateT.SingleOrDefault(x => x.PerfId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdPerforateT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdPerforateT.Where(x => x.PerfId == Id);
            dbContext.CdPerforateT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
