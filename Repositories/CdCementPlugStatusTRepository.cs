using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdCementPlugStatusTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdCementPlugStatusTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdCementPlugStatusT> GetRows()
        {
            return dbContext.CdCementPlugStatusT.Select(x => x).ToList();
        }

        public bool Create(CdCementPlugStatusT data)
        {
            data.CementPlugStatusId = NormalHelper.GenerateNormalKey();
            dbContext.CdCementPlugStatusT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdCementPlugStatusT data)
        {
            var model = dbContext.CdCementPlugStatusT.SingleOrDefault(x => x.CementPlugStatusId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdCementPlugStatusT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdCementPlugStatusT.Where(x => x.CementPlugStatusId == Id);
            dbContext.CdCementPlugStatusT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
