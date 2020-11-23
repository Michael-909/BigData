using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmOperEquipFailTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmOperEquipFailTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmOperEquipFailT> GetRows()
        {
            return dbContext.DmOperEquipFailT.Select(x => x).ToList();
        }

        public bool Create(DmOperEquipFailT data)
        {
            data.FailureId = NormalHelper.GenerateNormalKey();
            dbContext.DmOperEquipFailT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmOperEquipFailT data)
        {
            var model = dbContext.DmOperEquipFailT.SingleOrDefault(x => x.FailureId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmOperEquipFailT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmOperEquipFailT.Where(x => x.FailureId == Id);
            dbContext.DmOperEquipFailT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
