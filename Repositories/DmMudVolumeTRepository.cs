using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmMudVolumeTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmMudVolumeTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmMudVolumeT> GetRows()
        {
            return dbContext.DmMudVolumeT.Select(x => x).ToList();
        }

        public bool Create(DmMudVolumeT data)
        {
            data.MudVolumeId = NormalHelper.GenerateNormalKey();
            dbContext.DmMudVolumeT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmMudVolumeT data)
        {
            var model = dbContext.DmMudVolumeT.SingleOrDefault(x => x.MudVolumeId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmMudVolumeT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.DmMudVolumeT.Where(x => x.MudVolumeId == Id);
            dbContext.DmMudVolumeT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
