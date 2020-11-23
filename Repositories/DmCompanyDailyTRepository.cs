using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmCompanyDailyTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmCompanyDailyTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmCompanyDailyT> GetRows()
        {
            return dbContext.DmCompanyDailyT.Select(x => x).ToList();
        }

        public bool Create(DmCompanyDailyT data)
        {
            data.CompanyDailyId = NormalHelper.GenerateNormalKey();
            dbContext.DmCompanyDailyT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmCompanyDailyT data)
        {
            var model = dbContext.DmCompanyDailyT.SingleOrDefault(x => x.CompanyDailyId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmCompanyDailyT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmCompanyDailyT.Where(x => x.CompanyDailyId == Id);
            dbContext.DmCompanyDailyT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
