using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmOperEquipFailT>(jsonData);
            model.FailureId = NormalHelper.GenerateNormalKey();
            dbContext.DmOperEquipFailT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmOperEquipFailT.SingleOrDefault(x => x.FailureId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmOperEquipFailT>(jsonData);
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
