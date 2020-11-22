using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdWellSourceRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdWellSourceRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdWellSource> GetRows()
        {
            return dbContext.CdWellSource.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdWellSource>(jsonData);
            model.WellId = NormalHelper.GenerateNormalKey();
            dbContext.CdWellSource.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdWellSource.SingleOrDefault(x => x.WellId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdWellSource>(jsonData);
            dbContext.CdWellSource.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdWellSource.Where(x => x.WellId == Id);
            dbContext.CdWellSource.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
