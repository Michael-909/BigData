using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmActivityTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmActivityTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmActivityT> GetRows()
        {
            return dbContext.DmActivityT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmActivityT>(jsonData);
            model.ActivityId = NormalHelper.GenerateNormalKey();
            dbContext.DmActivityT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmActivityT.SingleOrDefault(x => x.ActivityId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmActivityT>(jsonData);
            dbContext.DmActivityT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmActivityT.Where(x => x.ActivityId == Id);
            dbContext.DmActivityT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
