using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmAfeRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmAfeRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmAfe> GetRows()
        {
            return dbContext.DmAfe.Select(x => x).ToList();
        }

        public bool Create(DmAfe data)
        {
            data.AfeId = NormalHelper.GenerateNormalKey();
            dbContext.DmAfe.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmAfe data)
        {
            var model = dbContext.DmAfe.SingleOrDefault(x => x.AfeId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmAfe.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmAfe.Where(x => x.AfeId == Id);
            dbContext.DmAfe.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
