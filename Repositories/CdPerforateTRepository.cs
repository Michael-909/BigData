using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdPerforateTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdPerforateTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdPerforateT> GetRows()
        {
            return dbContext.CdPerforateT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdPerforateT>(jsonData);
            model.PerfId = NormalHelper.GenerateNormalKey();
            dbContext.CdPerforateT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdPerforateT.SingleOrDefault(x => x.PerfId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdPerforateT>(jsonData);
            dbContext.CdPerforateT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdPerforateT.Where(x => x.PerfId == Id);
            dbContext.CdPerforateT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
