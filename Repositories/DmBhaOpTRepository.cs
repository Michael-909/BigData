using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmBhaOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmBhaOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmBhaOpT> GetRows()
        {
            return dbContext.DmBhaOpT.Select(x => x).ToList();
        }

        public bool Create(DmBhaOpT data)
        {
            data.BhaOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmBhaOpT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmBhaOpT data)
        {
            var model = dbContext.DmBhaOpT.SingleOrDefault(x => x.BhaOpId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmBhaOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmBhaOpT.Where(x => x.BhaOpId == Id);
            dbContext.DmBhaOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
