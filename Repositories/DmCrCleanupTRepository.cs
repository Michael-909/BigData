using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmCrCleanupTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmCrCleanupTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmCrCleanupT> GetRows()
        {
            return dbContext.DmCrCleanupT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmCrCleanupT>(jsonData);
            model.CleanupId = NormalHelper.GenerateNormalKey();
            dbContext.DmCrCleanupT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmCrCleanupT.SingleOrDefault(x => x.CleanupId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmCrCleanupT>(jsonData);
            dbContext.DmCrCleanupT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmCrCleanupT.Where(x => x.CleanupId == Id);
            dbContext.DmCrCleanupT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
