using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmRiserOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmRiserOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmRiserOpT> GetRows()
        {
            return dbContext.DmRiserOpT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmRiserOpT>(jsonData);
            model.RiserOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmRiserOpT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmRiserOpT.SingleOrDefault(x => x.RiserOpId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmRiserOpT>(jsonData);
            dbContext.DmRiserOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmRiserOpT.Where(x => x.RiserOpId == Id);
            dbContext.DmRiserOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
