using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdHoleSectTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdHoleSectTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdHoleSectT> GetRows()
        {
            return dbContext.CdHoleSectT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdHoleSectT>(jsonData);
            model.HoleSectId = NormalHelper.GenerateNormalKey();
            dbContext.CdHoleSectT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdHoleSectT.SingleOrDefault(x => x.HoleSectId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdHoleSectT>(jsonData);
            dbContext.CdHoleSectT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdHoleSectT.Where(x => x.HoleSectId == Id);
            dbContext.CdHoleSectT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
