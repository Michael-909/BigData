using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmPumpOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmPumpOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmPumpOpT> GetRows()
        {
            return dbContext.DmPumpOpT.Select(x => x).ToList();
        }

        public bool Create(DmPumpOpT data)
        {
            data.PumpOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmPumpOpT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmPumpOpT data)
        {
            var model = dbContext.DmPumpOpT.SingleOrDefault(x => x.PumpOpId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmPumpOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmPumpOpT.Where(x => x.PumpOpId == Id);
            dbContext.DmPumpOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
