﻿using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdCementJobTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdCementJobTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdCementJobT> GetRows()
        {
            return dbContext.CdCementJobT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdCementJobT>(jsonData);
            model.CementJobId = NormalHelper.GenerateNormalKey();
            dbContext.CdCementJobT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdCementJobT.SingleOrDefault(x => x.CementJobId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdCementJobT>(jsonData);
            dbContext.CdCementJobT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdCementJobT.Where(x => x.CementJobId == Id);
            dbContext.CdCementJobT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
