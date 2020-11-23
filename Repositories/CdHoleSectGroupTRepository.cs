using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdHoleSectGroupTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdHoleSectGroupTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdHoleSectGroupT> GetRows()
        {
            return dbContext.CdHoleSectGroupT.Select(x => x).ToList();
        }

        public bool Create(CdHoleSectGroupT data)
        {
            data.HoleSectGroupId = NormalHelper.GenerateNormalKey();
            dbContext.CdHoleSectGroupT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdHoleSectGroupT data)
        {
            var model = dbContext.CdHoleSectGroupT.SingleOrDefault(x => x.HoleSectGroupId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdHoleSectGroupT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdHoleSectGroupT.Where(x => x.HoleSectGroupId == Id);
            dbContext.CdHoleSectGroupT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
