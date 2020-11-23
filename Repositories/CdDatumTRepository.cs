using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdDatumTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdDatumTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdDatumT> GetRows()
        {
            return dbContext.CdDatumT.Select(x => x).ToList();
        }

        public bool Create(CdDatumT data)
        {
            data.DatumId = NormalHelper.GenerateNormalKey();
            dbContext.CdDatumT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdDatumT data)
        {
            var model = dbContext.CdDatumT.SingleOrDefault(x => x.DatumId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdDatumT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdDatumT.Where(x => x.DatumId == Id);
            dbContext.CdDatumT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
