using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmCentrifugeOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmCentrifugeOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmCentrifugeOpT> GetRows()
        {
            return dbContext.DmCentrifugeOpT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmCentrifugeOpT>(jsonData);
            model.CentrifugeOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmCentrifugeOpT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmCentrifugeOpT.SingleOrDefault(x => x.CentrifugeOpId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmCentrifugeOpT>(jsonData);
            dbContext.DmCentrifugeOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmCentrifugeOpT.Where(x => x.CentrifugeOpId == Id);
            dbContext.DmCentrifugeOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
