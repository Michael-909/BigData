using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmMudProductTranTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmMudProductTranTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmMudProductTranT> GetRows()
        {
            return dbContext.DmMudProductTranT.Select(x => x).ToList();
        }

        public bool Create(DmMudProductTranT data)
        {
            data.MudProductTranId = NormalHelper.GenerateNormalKey();
            dbContext.DmMudProductTranT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmMudProductTranT data)
        {
            var model = dbContext.DmMudProductTranT.SingleOrDefault(x => x.MudProductTranId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmMudProductTranT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmMudProductTranT.Where(x => x.MudProductTranId == Id);
            dbContext.DmMudProductTranT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
