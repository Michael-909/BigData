using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdWellSourceRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdWellSourceRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdWellSource> GetRows()
        {
            return dbContext.CdWellSource.Select(x => x).ToList();
        }

        public bool Create(CdWellSource data)
        {
            data.WellId = NormalHelper.GenerateNormalKey();
            dbContext.CdWellSource.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdWellSource data)
        {
            var model = dbContext.CdWellSource.SingleOrDefault(x => x.WellId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdWellSource.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdWellSource.Where(x => x.WellId == Id);
            dbContext.CdWellSource.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
