using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmRiserRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmRiserRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmRiser> GetRows()
        {
            return dbContext.DmRiser.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmRiser>(jsonData);
            model.RiserId = NormalHelper.GenerateNormalKey();
            dbContext.DmRiser.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmRiser.SingleOrDefault(x => x.RiserId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmRiser>(jsonData);
            dbContext.DmRiser.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmRiser.Where(x => x.RiserId == Id);
            dbContext.DmRiser.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
