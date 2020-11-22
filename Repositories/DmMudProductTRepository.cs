using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmMudProductTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmMudProductTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmMudProductT> GetRows()
        {
            return dbContext.DmMudProductT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmMudProductT>(jsonData);
            model.MudProductId = NormalHelper.GenerateNormalKey();
            dbContext.DmMudProductT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmMudProductT.SingleOrDefault(x => x.MudProductId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmMudProductT>(jsonData);
            dbContext.DmMudProductT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmMudProductT.Where(x => x.MudProductId == Id);
            dbContext.DmMudProductT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}