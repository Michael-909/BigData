using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmActivityTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmActivityTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmActivityT> GetRows()
        {
            return dbContext.DmActivityT.Select(x => x).ToList();
        }

        public bool Create(DmActivityT data)
        {
            data.ActivityId = NormalHelper.GenerateNormalKey();
            dbContext.DmActivityT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmActivityT data)
        {
            var model = dbContext.DmActivityT.SingleOrDefault(x => x.ActivityId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmActivityT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmActivityT.Where(x => x.ActivityId == Id);
            dbContext.DmActivityT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
