using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdAssemblyCompTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdAssemblyCompTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdAssemblyCompT> GetRows()
        {
            return dbContext.CdAssemblyCompT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdAssemblyCompT>(jsonData);
            model.AssemblyCompId = NormalHelper.GenerateNormalKey();
            dbContext.CdAssemblyCompT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdAssemblyCompT.SingleOrDefault(x => x.AssemblyCompId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdAssemblyCompT>(jsonData);
            dbContext.CdAssemblyCompT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdAssemblyCompT.Where(x => x.AssemblyCompId == Id);
            dbContext.CdAssemblyCompT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
