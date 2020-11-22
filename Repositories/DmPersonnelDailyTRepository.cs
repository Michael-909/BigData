using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmPersonnelDailyTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmPersonnelDailyTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmPersonnelDailyT> GetRows()
        {
            return dbContext.DmPersonnelDailyT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmPersonnelDailyT>(jsonData);
            model.PersonnelDetailId = NormalHelper.GenerateNormalKey();
            dbContext.DmPersonnelDailyT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmPersonnelDailyT.SingleOrDefault(x => x.PersonnelDetailId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmPersonnelDailyT>(jsonData);
            dbContext.DmPersonnelDailyT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmPersonnelDailyT.Where(x => x.PersonnelDetailId == Id);
            dbContext.DmPersonnelDailyT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
