using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdProjectSourceRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdProjectSourceRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdProjectSource> GetRows()
        {
            return dbContext.CdProjectSource.Select(x => x).ToList();
        }

        public bool Create(CdProjectSource data)
        {
            data.ProjectId = NormalHelper.GenerateNormalKey();
            dbContext.CdProjectSource.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdProjectSource data)
        {
            var model = dbContext.CdProjectSource.SingleOrDefault(x => x.ProjectId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdProjectSource.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdProjectSource.Where(x => x.ProjectId == Id);
            dbContext.CdProjectSource.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
