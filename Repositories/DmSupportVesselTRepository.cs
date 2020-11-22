using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmSupportVesselTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmSupportVesselTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmSupportVesselT> GetRows()
        {
            return dbContext.DmSupportVesselT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmSupportVesselT>(jsonData);
            model.SupportVesselId = NormalHelper.GenerateNormalKey();
            dbContext.DmSupportVesselT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmSupportVesselT.SingleOrDefault(x => x.SupportVesselId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmSupportVesselT>(jsonData);
            dbContext.DmSupportVesselT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmSupportVesselT.Where(x => x.SupportVesselId == Id);
            dbContext.DmSupportVesselT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
