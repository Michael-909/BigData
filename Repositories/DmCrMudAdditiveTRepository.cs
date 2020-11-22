using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmCrMudAdditiveTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmCrMudAdditiveTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmCrMudAdditiveT> GetRows()
        {
            return dbContext.DmCrMudAdditiveT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmCrMudAdditiveT>(jsonData);
            model.AdditiveId = NormalHelper.GenerateNormalKey();
            dbContext.DmCrMudAdditiveT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmCrMudAdditiveT.SingleOrDefault(x => x.AdditiveId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmCrMudAdditiveT>(jsonData);
            dbContext.DmCrMudAdditiveT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmCrMudAdditiveT.Where(x => x.AdditiveId == Id);
            dbContext.DmCrMudAdditiveT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
