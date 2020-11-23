using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmPitOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmPitOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmPitOpT> GetRows()
        {
            return dbContext.DmPitOpT.Select(x => x).ToList();
        }

        public bool Create(DmPitOpT data)
        {
            data.PitOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmPitOpT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmPitOpT data)
        {
            var model = dbContext.DmPitOpT.SingleOrDefault(x => x.PitOpId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmPitOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmPitOpT.Where(x => x.PitOpId == Id);
            dbContext.DmPitOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
