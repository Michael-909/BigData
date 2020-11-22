using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmPitOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmPitOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmPitOpT> GetRows()
        {
            return dbContext.DmPitOpT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmPitOpT>(jsonData);
            model.PitOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmPitOpT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmPitOpT.SingleOrDefault(x => x.PitOpId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmPitOpT>(jsonData);
            dbContext.DmPitOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmPitOpT.Where(x => x.PitOpId == Id);
            dbContext.DmPitOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
