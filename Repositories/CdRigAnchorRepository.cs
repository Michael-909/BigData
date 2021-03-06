﻿using BigData.Helpers;
using BigData.Models;
using System.Collections.Generic;
using System.Linq;

namespace BigData.Repositories
{
    public class CdRigAnchorRepository
    {
        private readonly jv_edm_dbContext dbContext;

        public CdRigAnchorRepository()
        {
            dbContext = new jv_edm_dbContext();
        }

        public IEnumerable<CdRigAnchor> GetRows()
        {
            return dbContext.CdRigAnchor.Select(x => x).ToList();
        }

        public bool Create(CdRigAnchor data)
        {
            data.AnchorId = NormalHelper.GenerateNormalKey();
            dbContext.CdRigAnchor.Add(data);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(string Id, CdRigAnchor data)
        {
            var model = dbContext.CdRigAnchor.SingleOrDefault(x => x.AnchorId == Id);
            if (model == null) return false;
            model = data;
            dbContext.CdRigAnchor.Update(model);
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(string Id)
        {
            var data = dbContext.CdRigAnchor.Where(x => x.AnchorId == Id);
            dbContext.CdRigAnchor.RemoveRange(data);
            return dbContext.SaveChanges() > 0;
        }
    }
}
