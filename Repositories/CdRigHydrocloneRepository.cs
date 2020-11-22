using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdRigHydrocloneRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdRigHydrocloneRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdRigHydroclone> GetRows()
        {
            return dbContext.CdRigHydroclone.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdRigHydroclone>(jsonData);
            model.HydrocloneId = NormalHelper.GenerateNormalKey();
            dbContext.CdRigHydroclone.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdRigHydroclone.SingleOrDefault(x => x.HydrocloneId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdRigHydroclone>(jsonData);
            dbContext.CdRigHydroclone.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.CdRigHydroclone.Where(x => x.HydrocloneId == Id);
            dbContext.CdRigHydroclone.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
