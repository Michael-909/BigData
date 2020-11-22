using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmAnchorOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmAnchorOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmAnchorOpT> GetRows()
        {
            return dbContext.DmAnchorOpT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmAnchorOpT>(jsonData);
            model.AnchorOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmAnchorOpT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmAnchorOpT.SingleOrDefault(x => x.AnchorOpId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmAnchorOpT>(jsonData);
            dbContext.DmAnchorOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmAnchorOpT.Where(x => x.AnchorOpId == Id);
            dbContext.DmAnchorOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
