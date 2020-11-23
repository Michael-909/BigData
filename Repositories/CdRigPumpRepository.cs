using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdRigPumpRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdRigPumpRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdRigPump> GetRows()
        {
            return dbContext.CdRigPump.Select(x => x).ToList();
        }

        public bool Create(CdRigPump data)
        {
            data.PumpId = NormalHelper.GenerateNormalKey();
            dbContext.CdRigPump.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdRigPump data)
        {
            var model = dbContext.CdRigPump.SingleOrDefault(x => x.PumpId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdRigPump.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdRigPump.Where(x => x.PumpId == Id);
            dbContext.CdRigPump.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
