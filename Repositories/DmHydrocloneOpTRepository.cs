using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmHydrocloneOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmHydrocloneOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmHydrocloneOpT> GetRows()
        {
            return dbContext.DmHydrocloneOpT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmHydrocloneOpT>(jsonData);
            model.HydrocloneOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmHydrocloneOpT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmHydrocloneOpT.SingleOrDefault(x => x.HydrocloneOpId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmHydrocloneOpT>(jsonData);
            dbContext.DmHydrocloneOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmHydrocloneOpT.Where(x => x.HydrocloneOpId == Id);
            dbContext.DmHydrocloneOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
