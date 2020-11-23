using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

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

        public bool Create(CdPolicy data)
        {
            data.PolicyId = NormalHelper.GenerateNormalKey();
            dbContext.CdPolicy.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdPolicy data)
        {
            var model = dbContext.CdPolicy.SingleOrDefault(x => x.PolicyId == Id);
            if (model == null) return false;
            model = data;
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
