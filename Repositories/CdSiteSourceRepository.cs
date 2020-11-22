using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdSiteSourceRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdSiteSourceRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdSiteSource> GetRows()
        {
            return dbContext.CdSiteSource.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdSiteSource>(jsonData);
            model.SiteId = NormalHelper.GenerateNormalKey();
            dbContext.CdSiteSource.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdSiteSource.SingleOrDefault(x => x.SiteId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdSiteSource>(jsonData);
            dbContext.CdSiteSource.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdSiteSource.Where(x => x.SiteId == Id);
            dbContext.CdSiteSource.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
