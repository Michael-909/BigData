using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmSafetyTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmSafetyTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmSafetyT> GetRows()
        {
            return dbContext.DmSafetyT.Select(x => x).ToList();
        }

        public bool Create(DmSafetyT data)
        {
            data.SafetyId = NormalHelper.GenerateNormalKey();
            dbContext.DmSafetyT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmSafetyT data)
        {
            var model = dbContext.DmSafetyT.SingleOrDefault(x => x.SafetyId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmSafetyT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmSafetyT.Where(x => x.SafetyId == Id);
            dbContext.DmSafetyT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
