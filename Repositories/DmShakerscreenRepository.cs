using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmShakerscreenRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmShakerscreenRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmShakerscreen> GetRows()
        {
            return dbContext.DmShakerscreen.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmShakerscreen>(jsonData);
            model.ShakerscreenId = NormalHelper.GenerateNormalKey();
            dbContext.DmShakerscreen.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmShakerscreen.SingleOrDefault(x => x.ShakerscreenId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmShakerscreen>(jsonData);
            dbContext.DmShakerscreen.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmShakerscreen.Where(x => x.ShakerscreenId == Id);
            dbContext.DmShakerscreen.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
