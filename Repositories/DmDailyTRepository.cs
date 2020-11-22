using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmDailyTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmDailyTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmDailyT> GetRows()
        {
            return dbContext.DmDailyT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmDailyT>(jsonData);
            model.DailyId = NormalHelper.GenerateNormalKey();
            dbContext.DmDailyT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmDailyT.SingleOrDefault(x => x.DailyId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmDailyT>(jsonData);
            dbContext.DmDailyT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmDailyT.Where(x => x.DailyId == Id);
            dbContext.DmDailyT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
