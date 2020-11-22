using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmSafetyTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmSafetyTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmSafetyT> GetRows()
        {
            return dbContext.DmSafetyT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmSafetyT>(jsonData);
            model.SafetyId = NormalHelper.GenerateNormalKey();
            dbContext.DmSafetyT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmSafetyT.SingleOrDefault(x => x.SafetyId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmSafetyT>(jsonData);
            dbContext.DmSafetyT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmSafetyT.Where(x => x.SafetyId == Id);
            dbContext.DmSafetyT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
