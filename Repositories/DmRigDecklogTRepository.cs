using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmRigDecklogTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmRigDecklogTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmRigDecklogT> GetRows()
        {
            return dbContext.DmRigDecklogT.Select(x => x).ToList();
        }

        public bool Create(DmRigDecklogT data)
        {
            data.RigDecklogId = NormalHelper.GenerateNormalKey();
            dbContext.DmRigDecklogT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmRigDecklogT data)
        {
            var model = dbContext.DmRigDecklogT.SingleOrDefault(x => x.RigDecklogId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmRigDecklogT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmRigDecklogT.Where(x => x.RigDecklogId == Id);
            dbContext.DmRigDecklogT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
