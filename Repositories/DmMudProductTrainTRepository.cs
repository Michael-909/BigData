using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmMudProductTrainTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmMudProductTrainTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmMudProductTranT> GetRows()
        {
            return dbContext.DmMudProductTranT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmMudProductTranT>(jsonData);
            model.MudProductTranId = NormalHelper.GenerateNormalKey();
            dbContext.DmMudProductTranT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmMudProductTranT.SingleOrDefault(x => x.MudProductTranId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmMudProductTranT>(jsonData);
            dbContext.DmMudProductTranT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmMudProductTranT.Where(x => x.MudProductTranId == Id);
            dbContext.DmMudProductTranT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
