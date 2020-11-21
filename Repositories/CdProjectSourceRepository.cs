using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdProjectSourceRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdProjectSourceRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdProjectSource> GetRows()
        {
            return dbContext.CdProjectSource.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdProjectSource>(jsonData);
            model.ProjectId = NormalHelper.GenerateNormalKey();
            dbContext.CdProjectSource.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdProjectSource.SingleOrDefault(x => x.ProjectId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdProjectSource>(jsonData);
            dbContext.CdProjectSource.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdProjectSource.Where(x => x.ProjectId == Id);
            dbContext.CdProjectSource.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
