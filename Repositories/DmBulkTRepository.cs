using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmBulkTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmBulkTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmBulkT> GetRows()
        {
            return dbContext.DmBulkT.Select(x => x).ToList();
        }

        public bool Create(DmBulkT data)
        {
            data.BulkId = NormalHelper.GenerateNormalKey();
            dbContext.DmBulkT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmBulkT data)
        {
            var model = dbContext.DmBulkT.SingleOrDefault(x => x.BulkId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmBulkT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmBulkT.Where(x => x.BulkId == Id);
            dbContext.DmBulkT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
