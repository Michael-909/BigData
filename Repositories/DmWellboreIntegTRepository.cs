using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmWellboreIntegTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmWellboreIntegTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmWellboreIntegT> GetRows()
        {
            return dbContext.DmWellboreIntegT.Select(x => x).ToList();
        }

        public bool Create(DmWellboreIntegT data)
        {
            data.WellboreIntegId = NormalHelper.GenerateNormalKey();
            dbContext.DmWellboreIntegT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmWellboreIntegT data)
        {
            var model = dbContext.DmWellboreIntegT.SingleOrDefault(x => x.WellboreIntegId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmWellboreIntegT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmWellboreIntegT.Where(x => x.WellboreIntegId == Id);
            dbContext.DmWellboreIntegT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
