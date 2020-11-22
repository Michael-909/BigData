using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmBulkTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmBulkTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmBulkT> GetRows()
        {
            return dbContext.DmBulkT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmBulkT>(jsonData);
            model.BulkId = NormalHelper.GenerateNormalKey();
            dbContext.DmBulkT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmBulkT.SingleOrDefault(x => x.BulkId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmBulkT>(jsonData);
            dbContext.DmBulkT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmBulkT.Where(x => x.BulkId == Id);
            dbContext.DmBulkT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
