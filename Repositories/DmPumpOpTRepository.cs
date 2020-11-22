using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmPumpOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmPumpOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmPumpOpT> GetRows()
        {
            return dbContext.DmPumpOpT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmPumpOpT>(jsonData);
            model.PumpOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmPumpOpT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmPumpOpT.SingleOrDefault(x => x.PumpOpId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmPumpOpT>(jsonData);
            dbContext.DmPumpOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmPumpOpT.Where(x => x.PumpOpId == Id);
            dbContext.DmPumpOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
