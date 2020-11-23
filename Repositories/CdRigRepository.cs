using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdRigRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdRigRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdRig> GetRows()
        {
            return dbContext.CdRig.Select(x => x).ToList();
        }

        public bool Create(CdRig data)
        {
            data.RigId = NormalHelper.GenerateNormalKey();
            dbContext.CdRig.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdRig data)
        {
            var model = dbContext.CdRig.SingleOrDefault(x => x.RigId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdRig.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdRig.Where(x => x.RigId == Id);
            dbContext.CdRig.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
