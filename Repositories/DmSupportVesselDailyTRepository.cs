using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmSupportVesselDailyTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmSupportVesselDailyTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmSupportVesselDailyT> GetRows()
        {
            return dbContext.DmSupportVesselDailyT.Select(x => x).ToList();
        }

        public bool Create(DmSupportVesselDailyT data)
        {
            data.SupportVesselDailyId = NormalHelper.GenerateNormalKey();
            dbContext.DmSupportVesselDailyT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmSupportVesselDailyT data)
        {
            var model = dbContext.DmSupportVesselDailyT.SingleOrDefault(x => x.SupportVesselDailyId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmSupportVesselDailyT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmSupportVesselDailyT.Where(x => x.SupportVesselDailyId == Id);
            dbContext.DmSupportVesselDailyT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
