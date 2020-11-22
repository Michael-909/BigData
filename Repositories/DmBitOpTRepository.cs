using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmBitOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmBitOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmBitOpT> GetRows()
        {
            return dbContext.DmBitOpT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmBitOpT>(jsonData);
            model.BitOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmBitOpT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmBitOpT.SingleOrDefault(x => x.BitOpId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmBitOpT>(jsonData);
            dbContext.DmBitOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmBitOpT.Where(x => x.BitOpId == Id);
            dbContext.DmBitOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
