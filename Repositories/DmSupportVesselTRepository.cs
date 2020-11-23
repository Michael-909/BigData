using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmSupportVesselTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmSupportVesselTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmSupportVesselT> GetRows()
        {
            return dbContext.DmSupportVesselT.Select(x => x).ToList();
        }

        public bool Create(DmSupportVesselT data)
        {
            data.SupportVesselId = NormalHelper.GenerateNormalKey();
            dbContext.DmSupportVesselT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmSupportVesselT data)
        {
            var model = dbContext.DmSupportVesselT.SingleOrDefault(x => x.SupportVesselId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmSupportVesselT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmSupportVesselT.Where(x => x.SupportVesselId == Id);
            dbContext.DmSupportVesselT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
