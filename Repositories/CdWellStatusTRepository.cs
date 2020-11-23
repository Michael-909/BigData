using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdWellStatusTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdWellStatusTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdWellStatusT> GetRows()
        {
            return dbContext.CdWellStatusT.Select(x => x).ToList();
        }

        public bool Create(CdWellStatusT data)
        {
            data.WellStatusId = NormalHelper.GenerateNormalKey();
            dbContext.CdWellStatusT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdWellStatusT data)
        {
            var model = dbContext.CdWellStatusT.SingleOrDefault(x => x.WellStatusId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdWellStatusT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdWellStatusT.Where(x => x.WellStatusId == Id);
            dbContext.CdWellStatusT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
