﻿using BigData.Helpers;
using BigData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigData.Repositories
{
    public class CdCementStageTRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdCementStageTRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdCementStageT> GetRows()
        {
            return dbContext.CdCementStageT.Select(x => x).ToList();
        }

        public bool Create(string jsonData)
        {
            var model = JsonConvert.DeserializeObject<CdCementStageT>(jsonData);
            model.CementStageId = NormalHelper.GenerateNormalKey();
            dbContext.CdCementStageT.Add(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, string jsonData)
        {
            var model = dbContext.CdCementStageT.SingleOrDefault(x => x.CementStageId == Id);
            if (model == null) return false;
            model = JsonConvert.DeserializeObject<CdCementStageT>(jsonData);
            dbContext.CdCementStageT.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdCementStageT.Where(x => x.CementStageId == Id);
            dbContext.CdCementStageT.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
