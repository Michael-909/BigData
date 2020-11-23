using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmAfeSuppRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmAfeSuppRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmAfeSupp> GetRows()
        {
            return dbContext.DmAfeSupp.Select(x => x).ToList();
        }

        public bool Create(DmAfeSupp data)
        {
            data.AfeSuppId = NormalHelper.GenerateNormalKey();
            dbContext.DmAfeSupp.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmAfeSupp data)
        {
            var model = dbContext.DmAfeSupp.SingleOrDefault(x => x.AfeSuppId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmAfeSupp.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmAfeSupp.Where(x => x.AfeSuppId == Id);
            dbContext.DmAfeSupp.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
