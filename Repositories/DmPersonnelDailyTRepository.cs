using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmPersonnelDailyTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmPersonnelDailyTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmPersonnelDailyT> GetRows()
        {
            return dbContext.DmPersonnelDailyT.Select(x => x).ToList();
        }

        public bool Create(DmPersonnelDailyT data)
        {
            data.PersonnelDetailId = NormalHelper.GenerateNormalKey();
            dbContext.DmPersonnelDailyT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmPersonnelDailyT data)
        {
            var model = dbContext.DmPersonnelDailyT.SingleOrDefault(x => x.PersonnelDetailId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmPersonnelDailyT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmPersonnelDailyT.Where(x => x.PersonnelDetailId == Id);
            dbContext.DmPersonnelDailyT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
