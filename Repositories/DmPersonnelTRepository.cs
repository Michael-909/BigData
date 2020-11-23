using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmPersonnelTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmPersonnelTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmPersonnelT> GetRows()
        {
            return dbContext.DmPersonnelT.Select(x => x).ToList();
        }

        public bool Create(DmPersonnelT data)
        {
            data.PersonnelId = NormalHelper.GenerateNormalKey();
            dbContext.DmPersonnelT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmPersonnelT data)
        {
            var model = dbContext.DmPersonnelT.SingleOrDefault(x => x.PersonnelId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmPersonnelT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmPersonnelT.Where(x => x.PersonnelId == Id);
            dbContext.DmPersonnelT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
