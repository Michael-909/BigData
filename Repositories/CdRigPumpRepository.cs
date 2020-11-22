using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdRigPumpRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdRigPumpRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdRigPump> GetRows()
        {
            return dbContext.CdRigPump.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdRigPump>(jsonData);
            model.PumpId = NormalHelper.GenerateNormalKey();
            dbContext.CdRigPump.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdRigPump.SingleOrDefault(x => x.PumpId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdRigPump>(jsonData);
            dbContext.CdRigPump.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdRigPump.Where(x => x.PumpId == Id);
            dbContext.CdRigPump.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
