﻿using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class DmCompanyTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmCompanyTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmCompanyT> GetRows()
        {
            return dbContext.DmCompanyT.Select(x => x).ToList();
        }

        public bool Create(DmCompanyT data)
        {
            data.CompanyId = NormalHelper.GenerateNormalKey();
            dbContext.DmCompanyT.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, DmCompanyT data)
        {
            var model = dbContext.DmCompanyT.SingleOrDefault(x => x.CompanyId == Id);
            if (model == null) return false;
            model = data;
            dbContext.DmCompanyT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmCompanyT.Where(x => x.CompanyId == Id);
            dbContext.DmCompanyT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
