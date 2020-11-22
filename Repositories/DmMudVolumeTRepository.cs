using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmMudVolumeT>(jsonData);
            model.MudVolumeId = NormalHelper.GenerateNormalKey();
            dbContext.DmMudVolumeT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmMudVolumeT.SingleOrDefault(x => x.MudVolumeId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmMudVolumeT>(jsonData);
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
