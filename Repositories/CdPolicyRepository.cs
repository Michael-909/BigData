using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdPolicyRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdPolicyRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdPolicy> GetRows()
        {
            return dbContext.CdPolicy.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdPolicy>(jsonData);
            model.PolicyId = NormalHelper.GenerateNormalKey();
            dbContext.CdPolicy.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdPolicy.SingleOrDefault(x => x.PolicyId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdPolicy>(jsonData);
            dbContext.CdPolicy.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdPolicy.Where(x => x.PolicyId == Id);
            dbContext.CdPolicy.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
