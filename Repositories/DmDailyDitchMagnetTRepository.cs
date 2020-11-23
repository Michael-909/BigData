using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmDailyDitchMagnetTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmDailyDitchMagnetTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmDailyDitchMagnetT> GetRows()
        {
            return dbContext.DmDailyDitchMagnetT.Select(x => x).ToList();
        }

        public bool Create(DmDailyDitchMagnetT data)
        {
            data.MagnetId = NormalHelper.GenerateNormalKey();
            dbContext.DmDailyDitchMagnetT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmDailyDitchMagnetT data)
        {
            var model = dbContext.DmDailyDitchMagnetT.SingleOrDefault(x => x.MagnetId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmDailyDitchMagnetT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmDailyDitchMagnetT.Where(x => x.MagnetId == Id);
            dbContext.DmDailyDitchMagnetT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
