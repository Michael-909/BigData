using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdCementFluidTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdCementFluidTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdCementFluidT> GetRows()
        {
            return dbContext.CdCementFluidT.Select(x => x).ToList();
        }

        public bool Create(CdCementFluidT data)
        {
            data.CementFluidId = NormalHelper.GenerateNormalKey();
            dbContext.CdCementFluidT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdCementFluidT data)
        {
            var model = dbContext.CdCementFluidT.SingleOrDefault(x => x.CementFluidId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdCementFluidT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdCementFluidT.Where(x => x.CementFluidId == Id);
            dbContext.CdCementFluidT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
