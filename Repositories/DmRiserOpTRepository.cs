using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmRiserOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmRiserOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmRiserOpT> GetRows()
        {
            return dbContext.DmRiserOpT.Select(x => x).ToList();
        }

        public bool Create(DmRiserOpT data)
        {
            data.RiserOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmRiserOpT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmRiserOpT data)
        {
            var model = dbContext.DmRiserOpT.SingleOrDefault(x => x.RiserOpId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmRiserOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmRiserOpT.Where(x => x.RiserOpId == Id);
            dbContext.DmRiserOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
