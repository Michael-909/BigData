using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmAfeSuppRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmAfeSuppRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmAfeSupp> GetRows()
        {
            return dbContext.DmAfeSupp.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmAfeSupp>(jsonData);
            model.AfeSuppId = NormalHelper.GenerateNormalKey();
            dbContext.DmAfeSupp.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmAfeSupp.SingleOrDefault(x => x.AfeSuppId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmAfeSupp>(jsonData);
            dbContext.DmAfeSupp.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmAfeSupp.Where(x => x.AfeSuppId == Id);
            dbContext.DmAfeSupp.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
