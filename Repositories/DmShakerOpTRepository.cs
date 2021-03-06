﻿using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmShakerOpTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmShakerOpTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmShakerOpT> GetRows()
        {
            return dbContext.DmShakerOpT.Select(x => x).ToList();
        }

        public bool Create(DmShakerOpT data)
        {
            data.ShakerOpId = NormalHelper.GenerateNormalKey();
            dbContext.DmShakerOpT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmShakerOpT data)
        {
            var model = dbContext.DmShakerOpT.SingleOrDefault(x => x.ShakerOpId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmShakerOpT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmShakerOpT.Where(x => x.ShakerOpId == Id);
            dbContext.DmShakerOpT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
