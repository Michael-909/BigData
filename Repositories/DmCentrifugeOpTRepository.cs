using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmCentrifugeOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmCentrifugeOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmCentrifugeOpT> GetRows()
        {
            return dbContext.DmCentrifugeOpT.Select(x => x).ToList();
        }

        public bool Create(DmCentrifugeOpT data)
        {
            data.CentrifugeOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmCentrifugeOpT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmCentrifugeOpT data)
        {
            var model = dbContext.DmCentrifugeOpT.SingleOrDefault(x => x.CentrifugeOpId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmCentrifugeOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmCentrifugeOpT.Where(x => x.CentrifugeOpId == Id);
            dbContext.DmCentrifugeOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
