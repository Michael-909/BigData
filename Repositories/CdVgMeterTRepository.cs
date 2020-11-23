using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdVgMeterTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdVgMeterTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdVgMeterT> GetRows()
        {
            return dbContext.CdVgMeterT.Select(x => x).ToList();
        }

        public bool Create(CdVgMeterT data)
        {
            data.VgMeterId = NormalHelper.GenerateNormalKey();
            dbContext.CdVgMeterT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdVgMeterT data)
        {
            var model = dbContext.CdVgMeterT.SingleOrDefault(x => x.VgMeterId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdVgMeterT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdVgMeterT.Where(x => x.VgMeterId == Id);
            dbContext.CdVgMeterT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
