using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdRigShakerRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdRigShakerRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdRigShaker> GetRows()
        {
            return dbContext.CdRigShaker.Select(x => x).ToList();
        }

        public bool Create(CdRigShaker data)
        {
            data.ShakerId = NormalHelper.GenerateNormalKey();
            dbContext.CdRigShaker.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdRigShaker data)
        {
            var model = dbContext.CdRigShaker.SingleOrDefault(x => x.ShakerId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdRigShaker.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdRigShaker.Where(x => x.ShakerId == Id);
            dbContext.CdRigShaker.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
