using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmBulkTranTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmBulkTranTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmBulkTranT> GetRows()
        {
            return dbContext.DmBulkTranT.Select(x => x).ToList();
        }

        public bool Create(DmBulkTranT data)
        {
            data.BulkTranId = NormalHelper.GenerateNormalKey();
            dbContext.DmBulkTranT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmBulkTranT data)
        {
            var model = dbContext.DmBulkTranT.SingleOrDefault(x => x.BulkTranId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmBulkTranT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmBulkTranT.Where(x => x.BulkTranId == Id);
            dbContext.DmBulkTranT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
