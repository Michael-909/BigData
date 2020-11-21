using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdFluidTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdFluidTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdFluidT> GetRows()
        {
            return dbContext.CdFluidT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdFluidT>(jsonData);
            model.FluidId = NormalHelper.GenerateNormalKey();
            dbContext.CdFluidT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdFluidT.SingleOrDefault(x => x.FluidId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdFluidT>(jsonData);
            dbContext.CdFluidT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdFluidT.Where(x => x.FluidId == Id);
            dbContext.CdFluidT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
