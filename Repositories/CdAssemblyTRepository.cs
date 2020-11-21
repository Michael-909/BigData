using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdAssemblyTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdAssemblyTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdAssemblyT> GetRows()
        {
            return dbContext.CdAssemblyT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdAssemblyT>(jsonData);
            model.AssemblyId = NormalHelper.GenerateNormalKey();
            dbContext.CdAssemblyT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdAssemblyT.SingleOrDefault(x => x.AssemblyId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdAssemblyT>(jsonData);
            dbContext.CdAssemblyT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdAssemblyT.Where(x => x.AssemblyId == Id);
            dbContext.CdAssemblyT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
