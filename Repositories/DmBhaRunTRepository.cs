using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmBhaRunTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmBhaRunTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmBhaRunT> GetRows()
        {
            return dbContext.DmBhaRunT.Select(x => x).ToList();
        }

        public bool Create(DmBhaRunT data)
        {
            data.BhaRunId = NormalHelper.GenerateNormalKey();
            dbContext.DmBhaRunT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmBhaRunT data)
        {
            var model = dbContext.DmBhaRunT.SingleOrDefault(x => x.BhaRunId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmBhaRunT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmBhaRunT.Where(x => x.BhaRunId == Id);
            dbContext.DmBhaRunT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
