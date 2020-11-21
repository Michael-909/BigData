using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdCementPlugStatusTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdCementPlugStatusTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdCementPlugStatusT> GetRows()
        {
            return dbContext.CdCementPlugStatusT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdCementPlugStatusT>(jsonData);
            model.CementPlugStatusId = NormalHelper.GenerateNormalKey();
            dbContext.CdCementPlugStatusT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdCementPlugStatusT.SingleOrDefault(x => x.CementPlugStatusId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdCementPlugStatusT>(jsonData);
            dbContext.CdCementPlugStatusT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdCementPlugStatusT.Where(x => x.CementPlugStatusId == Id);
            dbContext.CdCementPlugStatusT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
