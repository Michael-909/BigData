using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmRigOperationRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmRigOperationRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmRigOperation> GetRows()
        {
            return dbContext.DmRigOperation.Select(x => x).ToList();
        }

        public bool Create(DmRigOperation data)
        {
            data.RigOperationId = NormalHelper.GenerateNormalKey();
            dbContext.DmRigOperation.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmRigOperation data)
        {
            var model = dbContext.DmRigOperation.SingleOrDefault(x => x.RigOperationId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmRigOperation.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmRigOperation.Where(x => x.RigOperationId == Id);
            dbContext.DmRigOperation.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
