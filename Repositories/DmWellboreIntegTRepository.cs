using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmWellboreIntegTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmWellboreIntegTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmWellboreIntegT> GetRows()
        {
            return dbContext.DmWellboreIntegT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmWellboreIntegT>(jsonData);
            model.WellboreIntegId = NormalHelper.GenerateNormalKey();
            dbContext.DmWellboreIntegT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmWellboreIntegT.SingleOrDefault(x => x.WellboreIntegId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmWellboreIntegT>(jsonData);
            dbContext.DmWellboreIntegT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmWellboreIntegT.Where(x => x.WellboreIntegId == Id);
            dbContext.DmWellboreIntegT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
