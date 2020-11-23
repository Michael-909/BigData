using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmDailyTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmDailyTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmDailyT> GetRows()
        {
            return dbContext.DmDailyT.Select(x => x).ToList();
        }

        public bool Create(DmDailyT data)
        {
            data.DailyId = NormalHelper.GenerateNormalKey();
            dbContext.DmDailyT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmDailyT data)
        {
            var model = dbContext.DmDailyT.SingleOrDefault(x => x.DailyId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmDailyT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmDailyT.Where(x => x.DailyId == Id);
            dbContext.DmDailyT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
