using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    class CdWellboreFormationTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdWellboreFormationTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdWellboreFormationT> GetRows()
        {
            return dbContext.CdWellboreFormationT.Select(x => x).ToList();
        }

        public bool Create(CdWellboreFormationT data)
        {
            data.WellboreFormationId = NormalHelper.GenerateNormalKey();
            dbContext.CdWellboreFormationT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdWellboreFormationT data)
        {
            var model = dbContext.CdWellboreFormationT.SingleOrDefault(x => x.WellboreFormationId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdWellboreFormationT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdWellboreFormationT.Where(x => x.WellboreFormationId == Id);
            dbContext.CdWellboreFormationT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
