using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmBhaRunTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmBhaRunTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmBhaRunT> GetRows()
        {
            return dbContext.DmBhaRunT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmBhaRunT>(jsonData);
            model.BhaRunId = NormalHelper.GenerateNormalKey();
            dbContext.DmBhaRunT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmBhaRunT.SingleOrDefault(x => x.BhaRunId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmBhaRunT>(jsonData);
            dbContext.DmBhaRunT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmBhaRunT.Where(x => x.BhaRunId == Id);
            dbContext.DmBhaRunT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
