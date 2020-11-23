using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdWellboreTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdWellboreTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdWellboreT> GetRows()
        {
            return dbContext.CdWellboreT.Select(x => x).ToList();
        }

        public bool Create(CdWellboreT data)
        {
            data.WellboreId = NormalHelper.GenerateNormalKey();
            dbContext.CdWellboreT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdWellboreT data)
        {
            var model = dbContext.CdWellboreT.SingleOrDefault(x => x.WellboreId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdWellboreT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdWellboreT.Where(x => x.WellboreId == Id);
            dbContext.CdWellboreT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
