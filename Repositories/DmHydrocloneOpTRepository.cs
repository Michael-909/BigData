using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmHydrocloneOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmHydrocloneOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmHydrocloneOpT> GetRows()
        {
            return dbContext.DmHydrocloneOpT.Select(x => x).ToList();
        }

        public bool Create(DmHydrocloneOpT data)
        {
            data.HydrocloneOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmHydrocloneOpT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmHydrocloneOpT data)
        {
            var model = dbContext.DmHydrocloneOpT.SingleOrDefault(x => x.HydrocloneOpId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmHydrocloneOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmHydrocloneOpT.Where(x => x.HydrocloneOpId == Id);
            dbContext.DmHydrocloneOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
