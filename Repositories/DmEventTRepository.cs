﻿using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class DmEventTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public DmEventTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<DmEventT> GetRows()
        {
            return dbContext.DmEventT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<DmEventT>(jsonData);
            model.EventId = NormalHelper.GenerateNormalKey();
            dbContext.DmEventT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.DmEventT.SingleOrDefault(x => x.EventId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<DmEventT>(jsonData);
            dbContext.DmEventT.Update(model);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(string Id)
        {
            var data = dbContext.DmEventT.Where(x => x.EventId == Id);
            dbContext.DmEventT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
