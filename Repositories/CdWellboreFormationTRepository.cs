using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    class CdWellboreFormationTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdWellboreFormationTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdWellboreFormationT> GetRows()
        {
            return dbContext.CdWellboreFormationT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdWellboreFormationT>(jsonData);
            model.WellboreFormationId = NormalHelper.GenerateNormalKey();
            dbContext.CdWellboreFormationT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdWellboreFormationT.SingleOrDefault(x => x.WellboreFormationId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdWellboreFormationT>(jsonData);
            dbContext.CdWellboreFormationT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdWellboreFormationT.Where(x => x.WellboreFormationId == Id);
            dbContext.CdWellboreFormationT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
