using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmPersonnelTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmPersonnelTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmPersonnelT> GetRows()
        {
            return dbContext.DmPersonnelT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmPersonnelT>(jsonData);
            model.PersonnelId = NormalHelper.GenerateNormalKey();
            dbContext.DmPersonnelT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmPersonnelT.SingleOrDefault(x => x.PersonnelId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmPersonnelT>(jsonData);
            dbContext.DmPersonnelT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmPersonnelT.Where(x => x.PersonnelId == Id);
            dbContext.DmPersonnelT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
