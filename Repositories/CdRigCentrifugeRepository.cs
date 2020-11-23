using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdRigCentrifugeRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdRigCentrifugeRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdRigCentrifuge> GetRows()
        {
            return dbContext.CdRigCentrifuge.Select(x => x).ToList();
        }

        public bool Create(CdRigCentrifuge data)
        {
            data.CentrifugeId = NormalHelper.GenerateNormalKey();
            dbContext.CdRigCentrifuge.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdRigCentrifuge data)
        {
            var model = dbContext.CdRigCentrifuge.SingleOrDefault(x => x.CentrifugeId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdRigCentrifuge.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdRigCentrifuge.Where(x => x.CentrifugeId == Id);
            dbContext.CdRigCentrifuge.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
