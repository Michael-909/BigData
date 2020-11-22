using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdVgMeterTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdVgMeterTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdVgMeterT> GetRows()
        {
            return dbContext.CdVgMeterT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdVgMeterT>(jsonData);
            model.VgMeterId = NormalHelper.GenerateNormalKey();
            dbContext.CdVgMeterT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdVgMeterT.SingleOrDefault(x => x.VgMeterId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdVgMeterT>(jsonData);
            dbContext.CdVgMeterT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdVgMeterT.Where(x => x.VgMeterId == Id);
            dbContext.CdVgMeterT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
