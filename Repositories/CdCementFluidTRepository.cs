using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdCementFluidTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdCementFluidTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdCementFluidT> GetRows()
        {
            return dbContext.CdCementFluidT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdCementFluidT>(jsonData);
            model.CementFluidId = NormalHelper.GenerateNormalKey();
            dbContext.CdCementFluidT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdCementFluidT.SingleOrDefault(x => x.CementFluidId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdCementFluidT>(jsonData);
            dbContext.CdCementFluidT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdCementFluidT.Where(x => x.CementFluidId == Id);
            dbContext.CdCementFluidT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
