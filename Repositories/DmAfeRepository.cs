using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmAfeRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmAfeRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmAfe> GetRows()
        {
            return dbContext.DmAfe.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmAfe>(jsonData);
            model.AfeId = NormalHelper.GenerateNormalKey();
            dbContext.DmAfe.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmAfe.SingleOrDefault(x => x.AfeId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmAfe>(jsonData);
            dbContext.DmAfe.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmAfe.Where(x => x.AfeId == Id);
            dbContext.DmAfe.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
