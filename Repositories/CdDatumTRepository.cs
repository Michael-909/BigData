using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdDatumTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdDatumTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdDatumT> GetRows()
        {
            return dbContext.CdDatumT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdDatumT>(jsonData);
            model.DatumId = NormalHelper.GenerateNormalKey();
            dbContext.CdDatumT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdDatumT.SingleOrDefault(x => x.DatumId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdDatumT>(jsonData);
            dbContext.CdDatumT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdDatumT.Where(x => x.DatumId == Id);
            dbContext.CdDatumT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
