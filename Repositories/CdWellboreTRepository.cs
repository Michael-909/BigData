using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdWellboreTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdWellboreTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdWellboreT> GetRows()
        {
            return dbContext.CdWellboreT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdWellboreT>(jsonData);
            model.WellboreId = NormalHelper.GenerateNormalKey();
            dbContext.CdWellboreT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdWellboreT.SingleOrDefault(x => x.WellboreId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdWellboreT>(jsonData);
            dbContext.CdWellboreT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdWellboreT.Where(x => x.WellboreId == Id);
            dbContext.CdWellboreT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
