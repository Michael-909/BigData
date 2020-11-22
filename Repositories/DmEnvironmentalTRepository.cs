using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmEnvironmentalTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmEnvironmentalTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmEnvironmentalT> GetRows()
        {
            return dbContext.DmEnvironmentalT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmEnvironmentalT>(jsonData);
            model.EnvironmentalId = NormalHelper.GenerateNormalKey();
            dbContext.DmEnvironmentalT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmEnvironmentalT.SingleOrDefault(x => x.EnvironmentalId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmEnvironmentalT>(jsonData);
            dbContext.DmEnvironmentalT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmEnvironmentalT.Where(x => x.EnvironmentalId == Id);
            dbContext.DmEnvironmentalT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
